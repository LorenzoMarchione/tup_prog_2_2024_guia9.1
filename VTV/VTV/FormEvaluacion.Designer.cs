namespace VTV
{
    partial class FormEvaluacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTopo = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMedido = new System.Windows.Forms.TextBox();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.gbSimple = new System.Windows.Forms.GroupBox();
            this.cbCorrecto = new System.Windows.Forms.CheckBox();
            this.btSiguiente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbSimple.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(90, 22);
            this.tbNombre.Multiline = true;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNombre.Size = new System.Drawing.Size(189, 34);
            this.tbNombre.TabIndex = 2;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(90, 62);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescripcion.Size = new System.Drawing.Size(189, 34);
            this.tbDescripcion.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblTopo);
            this.groupBox1.Controls.Add(this.lblTipo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbMedido);
            this.groupBox1.Controls.Add(this.tbMax);
            this.groupBox1.Controls.Add(this.tbMin);
            this.groupBox1.Location = new System.Drawing.Point(12, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 83);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Evaluación parametrica";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Valor Medido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Máximo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mínimo";
            // 
            // lblTopo
            // 
            this.lblTopo.AutoSize = true;
            this.lblTopo.Location = new System.Drawing.Point(203, 53);
            this.lblTopo.Name = "lblTopo";
            this.lblTopo.Size = new System.Drawing.Size(58, 13);
            this.lblTopo.TabIndex = 5;
            this.lblTopo.Text = "Porcentaje";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(226, 53);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(0, 13);
            this.lblTipo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valores";
            // 
            // tbMedido
            // 
            this.tbMedido.Location = new System.Drawing.Point(153, 50);
            this.tbMedido.Name = "tbMedido";
            this.tbMedido.Size = new System.Drawing.Size(44, 20);
            this.tbMedido.TabIndex = 2;
            // 
            // tbMax
            // 
            this.tbMax.Enabled = false;
            this.tbMax.Location = new System.Drawing.Point(104, 50);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(44, 20);
            this.tbMax.TabIndex = 1;
            // 
            // tbMin
            // 
            this.tbMin.Enabled = false;
            this.tbMin.Location = new System.Drawing.Point(54, 50);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(44, 20);
            this.tbMin.TabIndex = 0;
            // 
            // gbSimple
            // 
            this.gbSimple.Controls.Add(this.cbCorrecto);
            this.gbSimple.Enabled = false;
            this.gbSimple.Location = new System.Drawing.Point(12, 191);
            this.gbSimple.Name = "gbSimple";
            this.gbSimple.Size = new System.Drawing.Size(261, 73);
            this.gbSimple.TabIndex = 5;
            this.gbSimple.TabStop = false;
            this.gbSimple.Text = "Evaluación simple";
            // 
            // cbCorrecto
            // 
            this.cbCorrecto.AutoSize = true;
            this.cbCorrecto.Location = new System.Drawing.Point(38, 31);
            this.cbCorrecto.Name = "cbCorrecto";
            this.cbCorrecto.Size = new System.Drawing.Size(181, 17);
            this.cbCorrecto.TabIndex = 0;
            this.cbCorrecto.Text = "¿El Funcionamiento es correcto?";
            this.cbCorrecto.UseVisualStyleBackColor = true;
            // 
            // btSiguiente
            // 
            this.btSiguiente.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSiguiente.Location = new System.Drawing.Point(90, 270);
            this.btSiguiente.Name = "btSiguiente";
            this.btSiguiente.Size = new System.Drawing.Size(119, 23);
            this.btSiguiente.TabIndex = 6;
            this.btSiguiente.Text = "Siguiente";
            this.btSiguiente.UseVisualStyleBackColor = true;
            // 
            // FormEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 304);
            this.Controls.Add(this.btSiguiente);
            this.Controls.Add(this.gbSimple);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEvaluacion";
            this.Text = "FormEvaluacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSimple.ResumeLayout(false);
            this.gbSimple.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbNombre;
        public System.Windows.Forms.TextBox tbDescripcion;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox tbMedido;
        public System.Windows.Forms.TextBox tbMax;
        public System.Windows.Forms.TextBox tbMin;
        public System.Windows.Forms.GroupBox gbSimple;
        public System.Windows.Forms.CheckBox cbCorrecto;
        public System.Windows.Forms.Button btSiguiente;
        public System.Windows.Forms.Label lblTopo;
    }
}