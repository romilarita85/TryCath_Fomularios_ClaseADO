namespace FormsClaseAdo03_12
{
    partial class FrmAlumno
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
            btnCancelar = new Button();
            numId = new NumericUpDown();
            lblId = new Label();
            grpMaterias = new GroupBox();
            chkProgramacion = new CheckBox();
            chkSistemasOperativos = new CheckBox();
            chkModelosSistemas = new CheckBox();
            chkMatematicas = new CheckBox();
            grpGenero = new GroupBox();
            rdoFemenino = new RadioButton();
            rdoMasculino = new RadioButton();
            rdoOtro = new RadioButton();
            grpMatricula = new GroupBox();
            rdoSi = new RadioButton();
            rdoNo = new RadioButton();
            btnAceptar = new Button();
            cmbCarrera = new ComboBox();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            lblCarrera = new Label();
            lblEdad = new Label();
            lblNombre = new Label();
            ((System.ComponentModel.ISupportInitialize)numId).BeginInit();
            grpMaterias.SuspendLayout();
            grpGenero.SuspendLayout();
            grpMatricula.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(451, 384);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(152, 42);
            btnCancelar.TabIndex = 57;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // numId
            // 
            numId.Location = new Point(161, 26);
            numId.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numId.Name = "numId";
            numId.Size = new Size(150, 27);
            numId.TabIndex = 56;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(38, 36);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 20);
            lblId.TabIndex = 55;
            lblId.Text = "Id";
            // 
            // grpMaterias
            // 
            grpMaterias.Controls.Add(chkProgramacion);
            grpMaterias.Controls.Add(chkSistemasOperativos);
            grpMaterias.Controls.Add(chkModelosSistemas);
            grpMaterias.Controls.Add(chkMatematicas);
            grpMaterias.Location = new Point(203, 249);
            grpMaterias.Name = "grpMaterias";
            grpMaterias.Size = new Size(442, 113);
            grpMaterias.TabIndex = 53;
            grpMaterias.TabStop = false;
            grpMaterias.Text = "Materias";
            // 
            // chkProgramacion
            // 
            chkProgramacion.AutoSize = true;
            chkProgramacion.Location = new Point(21, 36);
            chkProgramacion.Name = "chkProgramacion";
            chkProgramacion.Size = new Size(124, 24);
            chkProgramacion.TabIndex = 10;
            chkProgramacion.Text = "Programacion";
            chkProgramacion.UseVisualStyleBackColor = true;
            // 
            // chkSistemasOperativos
            // 
            chkSistemasOperativos.AutoSize = true;
            chkSistemasOperativos.Location = new Point(21, 66);
            chkSistemasOperativos.Name = "chkSistemasOperativos";
            chkSistemasOperativos.Size = new Size(163, 24);
            chkSistemasOperativos.TabIndex = 11;
            chkSistemasOperativos.Text = "Sistemas operativos";
            chkSistemasOperativos.UseVisualStyleBackColor = true;
            // 
            // chkModelosSistemas
            // 
            chkModelosSistemas.AutoSize = true;
            chkModelosSistemas.Location = new Point(251, 36);
            chkModelosSistemas.Name = "chkModelosSistemas";
            chkModelosSistemas.Size = new Size(160, 24);
            chkModelosSistemas.TabIndex = 12;
            chkModelosSistemas.Text = "Modelos y sistemas";
            chkModelosSistemas.UseVisualStyleBackColor = true;
            // 
            // chkMatematicas
            // 
            chkMatematicas.AutoSize = true;
            chkMatematicas.Location = new Point(251, 66);
            chkMatematicas.Name = "chkMatematicas";
            chkMatematicas.Size = new Size(116, 24);
            chkMatematicas.TabIndex = 13;
            chkMatematicas.Text = "Matematicas";
            chkMatematicas.UseVisualStyleBackColor = true;
            // 
            // grpGenero
            // 
            grpGenero.Controls.Add(rdoFemenino);
            grpGenero.Controls.Add(rdoMasculino);
            grpGenero.Controls.Add(rdoOtro);
            grpGenero.Location = new Point(357, 26);
            grpGenero.Name = "grpGenero";
            grpGenero.Size = new Size(251, 145);
            grpGenero.TabIndex = 45;
            grpGenero.TabStop = false;
            grpGenero.Text = "Genero";
            // 
            // rdoFemenino
            // 
            rdoFemenino.AutoSize = true;
            rdoFemenino.Location = new Point(41, 43);
            rdoFemenino.Name = "rdoFemenino";
            rdoFemenino.Size = new Size(95, 24);
            rdoFemenino.TabIndex = 7;
            rdoFemenino.TabStop = true;
            rdoFemenino.Text = "Femenino";
            rdoFemenino.UseVisualStyleBackColor = true;
            // 
            // rdoMasculino
            // 
            rdoMasculino.AutoSize = true;
            rdoMasculino.Location = new Point(41, 73);
            rdoMasculino.Name = "rdoMasculino";
            rdoMasculino.Size = new Size(97, 24);
            rdoMasculino.TabIndex = 8;
            rdoMasculino.TabStop = true;
            rdoMasculino.Text = "Masculino";
            rdoMasculino.UseVisualStyleBackColor = true;
            // 
            // rdoOtro
            // 
            rdoOtro.AutoSize = true;
            rdoOtro.Location = new Point(41, 103);
            rdoOtro.Name = "rdoOtro";
            rdoOtro.Size = new Size(60, 24);
            rdoOtro.TabIndex = 9;
            rdoOtro.TabStop = true;
            rdoOtro.Text = "Otro";
            rdoOtro.UseVisualStyleBackColor = true;
            // 
            // grpMatricula
            // 
            grpMatricula.Controls.Add(rdoSi);
            grpMatricula.Controls.Add(rdoNo);
            grpMatricula.Location = new Point(38, 249);
            grpMatricula.Name = "grpMatricula";
            grpMatricula.Size = new Size(126, 104);
            grpMatricula.TabIndex = 54;
            grpMatricula.TabStop = false;
            grpMatricula.Text = "Matricula";
            // 
            // rdoSi
            // 
            rdoSi.AutoSize = true;
            rdoSi.Location = new Point(38, 36);
            rdoSi.Name = "rdoSi";
            rdoSi.Size = new Size(42, 24);
            rdoSi.TabIndex = 15;
            rdoSi.TabStop = true;
            rdoSi.Text = "Si";
            rdoSi.UseVisualStyleBackColor = true;
            // 
            // rdoNo
            // 
            rdoNo.AutoSize = true;
            rdoNo.Location = new Point(38, 66);
            rdoNo.Name = "rdoNo";
            rdoNo.Size = new Size(50, 24);
            rdoNo.TabIndex = 16;
            rdoNo.TabStop = true;
            rdoNo.Text = "No";
            rdoNo.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(224, 384);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(152, 42);
            btnAceptar.TabIndex = 52;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // cmbCarrera
            // 
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Items.AddRange(new object[] { "Tecnicatura en Programacion", "Ingenieria Informatica", "Licenciatura en informatica" });
            cmbCarrera.Location = new Point(160, 173);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(151, 28);
            cmbCarrera.TabIndex = 51;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(160, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(151, 27);
            txtNombre.TabIndex = 50;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(160, 123);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(151, 27);
            txtEdad.TabIndex = 49;
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Location = new Point(38, 181);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(57, 20);
            lblCarrera.TabIndex = 48;
            lblCarrera.Text = "Carrera";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(38, 130);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(43, 20);
            lblEdad.TabIndex = 47;
            lblEdad.Text = "Edad";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(38, 82);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 46;
            lblNombre.Text = "Nombre";
            // 
            // FrmAlumno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 450);
            Controls.Add(btnCancelar);
            Controls.Add(numId);
            Controls.Add(lblId);
            Controls.Add(grpMaterias);
            Controls.Add(grpGenero);
            Controls.Add(grpMatricula);
            Controls.Add(btnAceptar);
            Controls.Add(cmbCarrera);
            Controls.Add(txtNombre);
            Controls.Add(txtEdad);
            Controls.Add(lblCarrera);
            Controls.Add(lblEdad);
            Controls.Add(lblNombre);
            Name = "FrmAlumno";
            Text = "Form1";
            Click += FrmAlumno_Load;
            ((System.ComponentModel.ISupportInitialize)numId).EndInit();
            grpMaterias.ResumeLayout(false);
            grpMaterias.PerformLayout();
            grpGenero.ResumeLayout(false);
            grpGenero.PerformLayout();
            grpMatricula.ResumeLayout(false);
            grpMatricula.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private NumericUpDown numId;
        private Label lblId;
        private GroupBox grpMaterias;
        private CheckBox chkProgramacion;
        private CheckBox chkSistemasOperativos;
        private CheckBox chkModelosSistemas;
        private CheckBox chkMatematicas;
        private GroupBox grpGenero;
        private RadioButton rdoFemenino;
        private RadioButton rdoMasculino;
        private RadioButton rdoOtro;
        private GroupBox grpMatricula;
        private RadioButton rdoSi;
        private RadioButton rdoNo;
        private Button btnAceptar;
        private ComboBox cmbCarrera;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private Label lblCarrera;
        private Label lblEdad;
        private Label lblNombre;
    }
}
