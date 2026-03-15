namespace pryDiFiniGimnasio
{
    partial class frmGimnasio
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
            lblTitulo = new Label();
            lblDni = new Label();
            mskDni = new MaskedTextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblEdad = new Label();
            nudEdad = new NumericUpDown();
            lblPeso = new Label();
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            lblAltura = new Label();
            txtAñoEntrenando = new TextBox();
            lblAñosEntrenando = new Label();
            btnCalcular = new Button();
            btnClasificar = new Button();
            btnMostrar = new Button();
            btnSalir = new Button();
            lstMostrar = new ListBox();
            lstClasificar = new ListBox();
            lblResultadosPeso = new Label();
            ((System.ComponentModel.ISupportInitialize)nudEdad).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(262, 26);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Inscribite en el gimnasio";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(12, 67);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(83, 15);
            lblDni.TabIndex = 1;
            lblDni.Text = "Ingrese su DNI";
            // 
            // mskDni
            // 
            mskDni.Location = new Point(101, 64);
            mskDni.Mask = "00-000-000";
            mskDni.Name = "mskDni";
            mskDni.Size = new Size(100, 23);
            mskDni.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 124);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(107, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Ingrese su Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(125, 121);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(12, 185);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(89, 15);
            lblEdad.TabIndex = 5;
            lblEdad.Text = "Ingrese su Edad";
            // 
            // nudEdad
            // 
            nudEdad.Location = new Point(107, 183);
            nudEdad.Maximum = new decimal(new int[] { 70, 0, 0, 0 });
            nudEdad.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            nudEdad.Name = "nudEdad";
            nudEdad.Size = new Size(49, 23);
            nudEdad.TabIndex = 6;
            nudEdad.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(280, 67);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(88, 15);
            lblPeso.TabIndex = 7;
            lblPeso.Text = "Ingrese su peso";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(374, 64);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 8;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(379, 121);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 10;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(280, 124);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(93, 15);
            lblAltura.TabIndex = 9;
            lblAltura.Text = "Ingrese su altura";
            // 
            // txtAñoEntrenando
            // 
            txtAñoEntrenando.Location = new Point(379, 182);
            txtAñoEntrenando.Name = "txtAñoEntrenando";
            txtAñoEntrenando.Size = new Size(100, 23);
            txtAñoEntrenando.TabIndex = 12;
            // 
            // lblAñosEntrenando
            // 
            lblAñosEntrenando.AutoSize = true;
            lblAñosEntrenando.Location = new Point(280, 185);
            lblAñosEntrenando.Name = "lblAñosEntrenando";
            lblAñosEntrenando.Size = new Size(98, 15);
            lblAñosEntrenando.TabIndex = 11;
            lblAñosEntrenando.Text = "Años entrenando";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(374, 246);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(100, 23);
            btnCalcular.TabIndex = 13;
            btnCalcular.Text = "Calcular IMC";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnClasificar
            // 
            btnClasificar.Location = new Point(268, 246);
            btnClasificar.Name = "btnClasificar";
            btnClasificar.Size = new Size(100, 23);
            btnClasificar.TabIndex = 14;
            btnClasificar.Text = "Clasificar";
            btnClasificar.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(162, 246);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(100, 23);
            btnMostrar.TabIndex = 15;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Firebrick;
            btnSalir.ForeColor = Color.Black;
            btnSalir.Location = new Point(12, 292);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(144, 23);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += this.btnSalir_Click;
            // 
            // lstMostrar
            // 
            lstMostrar.FormattingEnabled = true;
            lstMostrar.Location = new Point(12, 349);
            lstMostrar.Name = "lstMostrar";
            lstMostrar.Size = new Size(250, 154);
            lstMostrar.TabIndex = 17;
            // 
            // lstClasificar
            // 
            lstClasificar.FormattingEnabled = true;
            lstClasificar.Location = new Point(280, 379);
            lstClasificar.Name = "lstClasificar";
            lstClasificar.Size = new Size(250, 124);
            lstClasificar.TabIndex = 18;
            // 
            // lblResultadosPeso
            // 
            lblResultadosPeso.AutoSize = true;
            lblResultadosPeso.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultadosPeso.Location = new Point(280, 349);
            lblResultadosPeso.Name = "lblResultadosPeso";
            lblResultadosPeso.Size = new Size(142, 21);
            lblResultadosPeso.TabIndex = 19;
            lblResultadosPeso.Text = "lblResultadosPeso";
            // 
            // frmGimnasio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 517);
            Controls.Add(lblResultadosPeso);
            Controls.Add(lstClasificar);
            Controls.Add(lstMostrar);
            Controls.Add(btnSalir);
            Controls.Add(btnMostrar);
            Controls.Add(btnClasificar);
            Controls.Add(btnCalcular);
            Controls.Add(txtAñoEntrenando);
            Controls.Add(lblAñosEntrenando);
            Controls.Add(txtAltura);
            Controls.Add(lblAltura);
            Controls.Add(txtPeso);
            Controls.Add(lblPeso);
            Controls.Add(nudEdad);
            Controls.Add(lblEdad);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(mskDni);
            Controls.Add(lblDni);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmGimnasio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmGimnasio";
            ((System.ComponentModel.ISupportInitialize)nudEdad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblDni;
        private MaskedTextBox mskDni;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblEdad;
        private NumericUpDown nudEdad;
        private Label lblPeso;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private Label lblAltura;
        private TextBox txtAñoEntrenando;
        private Label lblAñosEntrenando;
        private Button btnCalcular;
        private Button btnClasificar;
        private Button btnMostrar;
        private Button btnSalir;
        private ListBox lstMostrar;
        private ListBox lstClasificar;
        private Label lblResultadosPeso;
    }
}
