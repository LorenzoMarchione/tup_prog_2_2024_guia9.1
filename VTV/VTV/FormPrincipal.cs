using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VTV.Excepciones;
using VTV.Models;

namespace VTV.Models
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        FiscalizadorVTV fiscalizador;
        Propietario pro;
        int cont;
        FormVer ver = new FormVer();
        private void btCarga_Click(object sender, EventArgs e)
        {
            
            string nombre = tbNombre.Text;
            string correo = tbCorreo.Text;
            string patente = tbPatente.Text;
         
            try
            {
                int dni = Convert.ToInt32(tbDNI.Text);

                pro = new Propietario(dni, nombre, correo);
            }
            catch (FormatException ex) 
            {
                MessageBox.Show("Ingrese solo numeros en DNI"+ex.Message);
                tbDNI.Clear();
            }
            catch (NroDNIBajoException ex) 
            { 
                MessageBox.Show(ex.Message); 
                tbDNI.Clear();
            }
            catch (DireccionDeCorreoInvalidaException ex) 
            {
                MessageBox.Show(ex.Message);
                tbCorreo.Clear();
            }
            try 
            {
                fiscalizador.AgregarVTV(patente, pro);
            }
            catch (NoEsPatenteException ex) 
            { 
                MessageBox.Show(ex.Message); 
                tbPatente.Clear();
            }
            ver.lbVer.Items.Clear();
            ver.lbVer.Items.Add($"{fiscalizador.vtvs[cont].patente} {fiscalizador.vtvs[cont].propietario}");
            foreach (Evaluacion eva in fiscalizador.vtvs[cont].verificaciones) 
            {
                FormEvaluacion evaluacion = new FormEvaluacion();
                evaluacion.tbDescripcion.Text = eva.descripcion;
                evaluacion.tbNombre.Text = eva.nombre;
                if ( eva is EvaluacionParametrica)
                {
                    EvaluacionParametrica param = eva as EvaluacionParametrica;
                    evaluacion.tbMin.Text = Convert.ToString(param.valormin);
                    evaluacion.tbMax.Text = Convert.ToString(param.valormax);
                    evaluacion.lblTopo.Text = param.unidad;
                    if ( evaluacion.ShowDialog()== DialogResult.OK)
                    {
                        param.valormedido = Convert.ToDouble(evaluacion.tbMedido.Text);
                    }
                }
                else
                {
                    evaluacion.gbSimple.Enabled = true;
                    evaluacion.groupBox1.Enabled = false;
                    Evaluacionsimple a = eva as Evaluacionsimple;
                    if (evaluacion.ShowDialog() == DialogResult.OK)
                    {
                        a.haverificado = evaluacion.cbCorrecto.Checked;
                    }
                }
                ver.lbVer.Items.Add(eva.ToString());
            }
            ver.lbVer.Items.Add($"Resultado: {fiscalizador[cont].Aprobacion} - Vencimiento: {fiscalizador[cont].fecha}");
            ver.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fiscalizador = new FiscalizadorVTV();
            cont = 0;
        }

        private void btVerVTV_Click(object sender, EventArgs e)
        {
            ver.lbVer.Items.Clear();
            fiscalizador.OrdenarVTVsPorDNIPropietario();
            for(int i = 0; i < fiscalizador.CantidadVTV; i++)
            {
                ver.lbVer.Items.Add(fiscalizador.vtvs[i].ToString());
            }
            ver.ShowDialog();
        }

        private void btBuscarPat_Click(object sender, EventArgs e)
        {
            string pat = tbPatente.Text;
            ver.lbVer.Items.Clear();
            List<VTV> a = fiscalizador.VerVTVPorPatente(pat);
            foreach(VTV v in a)
            {
                ver.lbVer.Items.Add(v.ToString());
            }
            ver.ShowDialog();
        }
    }
}
