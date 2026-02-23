namespace pryDiFiniSeguroMedico
{
    partial class frmSeguroMedico
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDni = new Label();
            mskDni = new MaskedTextBox();
            lblTitulo = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblEdad = new Label();
            nudEdad = new NumericUpDown();
            lblSexo = new Label();
            cmbSexo = new ComboBox();
            lblLicenciaValida = new Label();
            lblExperiencia = new Label();
            txtExperiencia = new TextBox();
            txtEnfermedades = new TextBox();
            lblEnfermedades = new Label();
            txtAccidentes = new TextBox();
            label1 = new Label();
            lblPlan = new Label();
            rdbBasico = new RadioButton();
            rdbIntermedio = new RadioButton();
            rdbPremium = new RadioButton();
            btnAceptar = new Button();
            btnSalir = new Button();
            lstResultados = new ListBox();
            cmbLicenciaValida = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nudEdad).BeginInit();
            SuspendLayout();
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(12, 62);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 0;
            lblDni.Text = "DNI";
            // 
            // mskDni
            // 
            mskDni.Location = new Point(45, 59);
            mskDni.Mask = "99999999";
            mskDni.Name = "mskDni";
            mskDni.Size = new Size(94, 23);
            mskDni.TabIndex = 1;
            mskDni.ValidatingType = typeof(int);
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(367, 30);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Sistema complejo de seguro médico";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 113);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(69, 110);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(70, 23);
            txtNombre.TabIndex = 4;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(12, 162);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 5;
            lblEdad.Text = "Edad";
            // 
            // nudEdad
            // 
            nudEdad.Location = new Point(51, 160);
            nudEdad.Maximum = new decimal(new int[] { 80, 0, 0, 0 });
            nudEdad.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            nudEdad.Name = "nudEdad";
            nudEdad.Size = new Size(38, 23);
            nudEdad.TabIndex = 7;
            nudEdad.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(204, 162);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(32, 15);
            lblSexo.TabIndex = 8;
            lblSexo.Text = "Sexo";
            // 
            // cmbSexo
            // 
            cmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cmbSexo.Location = new Point(237, 159);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(79, 23);
            cmbSexo.TabIndex = 9;
            // 
            // lblLicenciaValida
            // 
            lblLicenciaValida.AutoSize = true;
            lblLicenciaValida.Location = new Point(204, 62);
            lblLicenciaValida.Name = "lblLicenciaValida";
            lblLicenciaValida.Size = new Size(84, 15);
            lblLicenciaValida.TabIndex = 10;
            lblLicenciaValida.Text = "Licencia valida";
            // 
            // lblExperiencia
            // 
            lblExperiencia.AutoSize = true;
            lblExperiencia.Location = new Point(204, 113);
            lblExperiencia.Name = "lblExperiencia";
            lblExperiencia.Size = new Size(113, 15);
            lblExperiencia.TabIndex = 12;
            lblExperiencia.Text = "Años de experiencia";
            // 
            // txtExperiencia
            // 
            txtExperiencia.Location = new Point(323, 110);
            txtExperiencia.Name = "txtExperiencia";
            txtExperiencia.Size = new Size(37, 23);
            txtExperiencia.TabIndex = 13;
            txtExperiencia.KeyPress += txtExperiencia_KeyPress;
            // 
            // txtEnfermedades
            // 
            txtEnfermedades.Location = new Point(250, 212);
            txtEnfermedades.Name = "txtEnfermedades";
            txtEnfermedades.Size = new Size(67, 23);
            txtEnfermedades.TabIndex = 15;
            txtEnfermedades.KeyPress += txtEnfermedades_KeyPress;
            // 
            // lblEnfermedades
            // 
            lblEnfermedades.AutoSize = true;
            lblEnfermedades.Location = new Point(12, 215);
            lblEnfermedades.Name = "lblEnfermedades";
            lblEnfermedades.Size = new Size(232, 15);
            lblEnfermedades.TabIndex = 14;
            lblEnfermedades.Text = "Cantidades de enfermedades preexistentes";
            // 
            // txtAccidentes
            // 
            txtAccidentes.Location = new Point(262, 259);
            txtAccidentes.Name = "txtAccidentes";
            txtAccidentes.Size = new Size(55, 23);
            txtAccidentes.TabIndex = 17;
            txtAccidentes.KeyPress += txtAccidentes_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 262);
            label1.Name = "label1";
            label1.Size = new Size(244, 15);
            label1.TabIndex = 16;
            label1.Text = "Cantidad de accidentes en los ultimos 5 años";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(393, 62);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(72, 15);
            lblPlan.TabIndex = 18;
            lblPlan.Text = "Tipo de plan";
            // 
            // rdbBasico
            // 
            rdbBasico.AutoSize = true;
            rdbBasico.Location = new Point(417, 80);
            rdbBasico.Name = "rdbBasico";
            rdbBasico.Size = new Size(59, 19);
            rdbBasico.TabIndex = 19;
            rdbBasico.TabStop = true;
            rdbBasico.Text = "Basico";
            rdbBasico.UseVisualStyleBackColor = true;
            // 
            // rdbIntermedio
            // 
            rdbIntermedio.AutoSize = true;
            rdbIntermedio.Location = new Point(417, 105);
            rdbIntermedio.Name = "rdbIntermedio";
            rdbIntermedio.Size = new Size(83, 19);
            rdbIntermedio.TabIndex = 20;
            rdbIntermedio.TabStop = true;
            rdbIntermedio.Text = "Intermedio";
            rdbIntermedio.UseVisualStyleBackColor = true;
            // 
            // rdbPremium
            // 
            rdbPremium.AutoSize = true;
            rdbPremium.Location = new Point(417, 130);
            rdbPremium.Name = "rdbPremium";
            rdbPremium.Size = new Size(74, 19);
            rdbPremium.TabIndex = 21;
            rdbPremium.TabStop = true;
            rdbPremium.Text = "Premium";
            rdbPremium.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(357, 307);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(143, 23);
            btnAceptar.TabIndex = 22;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(12, 307);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(143, 23);
            btnSalir.TabIndex = 23;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(12, 344);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(488, 94);
            lstResultados.TabIndex = 24;
            // 
            // cmbLicenciaValida
            // 
            cmbLicenciaValida.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLicenciaValida.FormattingEnabled = true;
            cmbLicenciaValida.Items.AddRange(new object[] { "SI", "NO" });
            cmbLicenciaValida.Location = new Point(294, 59);
            cmbLicenciaValida.Name = "cmbLicenciaValida";
            cmbLicenciaValida.Size = new Size(66, 23);
            cmbLicenciaValida.TabIndex = 25;
            // 
            // frmSeguroMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 450);
            Controls.Add(cmbLicenciaValida);
            Controls.Add(lstResultados);
            Controls.Add(btnSalir);
            Controls.Add(btnAceptar);
            Controls.Add(rdbPremium);
            Controls.Add(rdbIntermedio);
            Controls.Add(rdbBasico);
            Controls.Add(lblPlan);
            Controls.Add(txtAccidentes);
            Controls.Add(label1);
            Controls.Add(txtEnfermedades);
            Controls.Add(lblEnfermedades);
            Controls.Add(txtExperiencia);
            Controls.Add(lblExperiencia);
            Controls.Add(lblLicenciaValida);
            Controls.Add(cmbSexo);
            Controls.Add(lblSexo);
            Controls.Add(nudEdad);
            Controls.Add(lblEdad);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Controls.Add(mskDni);
            Controls.Add(lblDni);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmSeguroMedico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSeguroMedico";
            ((System.ComponentModel.ISupportInitialize)nudEdad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDni;
        private MaskedTextBox mskDni;
        private Label lblTitulo;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblEdad;
        private NumericUpDown nudEdad;
        private Label lblSexo;
        private ComboBox cmbSexo;
        private Label lblLicenciaValida;
        private Label lblExperiencia;
        private TextBox txtExperiencia;
        private TextBox txtEnfermedades;
        private Label lblEnfermedades;
        private TextBox txtAccidentes;
        private Label label1;
        private Label lblPlan;
        private RadioButton rdbBasico;
        private RadioButton rdbIntermedio;
        private RadioButton rdbPremium;
        private Button btnAceptar;
        private Button btnSalir;
        private ListBox lstResultados;
        private ComboBox cmbLicenciaValida;
    }
}
