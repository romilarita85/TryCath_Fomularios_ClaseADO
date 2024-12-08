namespace ClasesyForms27_11
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
            lblNombre = new Label();
            lblEdad = new Label();
            lblCarrera = new Label();
            txtEdad = new TextBox();
            txtNombre = new TextBox();
            cmbCarrera = new ComboBox();
            rdoFemenino = new RadioButton();
            rdoMasculino = new RadioButton();
            rdoOtro = new RadioButton();
            chkProgramacion = new CheckBox();
            chkSistemasOperativos = new CheckBox();
            chkModelosSistemas = new CheckBox();
            chkMatematicas = new CheckBox();
            btnMostrar = new Button();
            rdoNo = new RadioButton();
            rdoSi = new RadioButton();
            grpMatricula = new GroupBox();
            grpMaterias = new GroupBox();
            grpGenero = new GroupBox();
            txtDato = new TextBox();
            grpMatricula.SuspendLayout();
            grpMaterias.SuspendLayout();
            grpGenero.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(27, 33);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(27, 81);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(43, 20);
            lblEdad.TabIndex = 1;
            lblEdad.Text = "Edad";
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Location = new Point(27, 134);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(57, 20);
            lblCarrera.TabIndex = 2;
            lblCarrera.Text = "Carrera";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(149, 74);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(151, 27);
            txtEdad.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(149, 26);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(151, 27);
            txtNombre.TabIndex = 5;
            // 
            // cmbCarrera
            // 
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Items.AddRange(new object[] { "Tecnicatura en Programacion", "Ingenieria Informatica", "Licenciatura en informatica" });
            cmbCarrera.Location = new Point(149, 126);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(151, 28);
            cmbCarrera.TabIndex = 6;
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
            // chkProgramacion
            // 
            chkProgramacion.AutoSize = true;
            chkProgramacion.Location = new Point(20, 44);
            chkProgramacion.Name = "chkProgramacion";
            chkProgramacion.Size = new Size(124, 24);
            chkProgramacion.TabIndex = 10;
            chkProgramacion.Text = "Programacion";
            chkProgramacion.UseVisualStyleBackColor = true;
            // 
            // chkSistemasOperativos
            // 
            chkSistemasOperativos.AutoSize = true;
            chkSistemasOperativos.Location = new Point(20, 74);
            chkSistemasOperativos.Name = "chkSistemasOperativos";
            chkSistemasOperativos.Size = new Size(163, 24);
            chkSistemasOperativos.TabIndex = 11;
            chkSistemasOperativos.Text = "Sistemas operativos";
            chkSistemasOperativos.UseVisualStyleBackColor = true;
            // 
            // chkModelosSistemas
            // 
            chkModelosSistemas.AutoSize = true;
            chkModelosSistemas.Location = new Point(20, 104);
            chkModelosSistemas.Name = "chkModelosSistemas";
            chkModelosSistemas.Size = new Size(160, 24);
            chkModelosSistemas.TabIndex = 12;
            chkModelosSistemas.Text = "Modelos y sistemas";
            chkModelosSistemas.UseVisualStyleBackColor = true;
            // 
            // chkMatematicas
            // 
            chkMatematicas.AutoSize = true;
            chkMatematicas.Location = new Point(20, 134);
            chkMatematicas.Name = "chkMatematicas";
            chkMatematicas.Size = new Size(116, 24);
            chkMatematicas.TabIndex = 13;
            chkMatematicas.Text = "Matematicas";
            chkMatematicas.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(100, 539);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(107, 42);
            btnMostrar.TabIndex = 14;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
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
            // grpMatricula
            // 
            grpMatricula.Controls.Add(rdoSi);
            grpMatricula.Controls.Add(rdoNo);
            grpMatricula.Location = new Point(352, 33);
            grpMatricula.Name = "grpMatricula";
            grpMatricula.Size = new Size(126, 104);
            grpMatricula.TabIndex = 17;
            grpMatricula.TabStop = false;
            grpMatricula.Text = "Matricula";
            // 
            // grpMaterias
            // 
            grpMaterias.Controls.Add(chkProgramacion);
            grpMaterias.Controls.Add(chkSistemasOperativos);
            grpMaterias.Controls.Add(chkModelosSistemas);
            grpMaterias.Controls.Add(chkMatematicas);
            grpMaterias.Location = new Point(27, 347);
            grpMaterias.Name = "grpMaterias";
            grpMaterias.Size = new Size(251, 186);
            grpMaterias.TabIndex = 17;
            grpMaterias.TabStop = false;
            grpMaterias.Text = "Materias";
            // 
            // grpGenero
            // 
            grpGenero.Controls.Add(rdoFemenino);
            grpGenero.Controls.Add(rdoMasculino);
            grpGenero.Controls.Add(rdoOtro);
            grpGenero.Location = new Point(27, 186);
            grpGenero.Name = "grpGenero";
            grpGenero.Size = new Size(251, 145);
            grpGenero.TabIndex = 0;
            grpGenero.TabStop = false;
            grpGenero.Text = "Genero";
            // 
            // txtDato
            // 
            txtDato.Location = new Point(315, 229);
            txtDato.Multiline = true;
            txtDato.Name = "txtDato";
            txtDato.Size = new Size(279, 216);
            txtDato.TabIndex = 18;
            // 
            // FrmAlumno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 614);
            Controls.Add(txtDato);
            Controls.Add(grpMaterias);
            Controls.Add(grpGenero);
            Controls.Add(grpMatricula);
            Controls.Add(btnMostrar);
            Controls.Add(cmbCarrera);
            Controls.Add(txtNombre);
            Controls.Add(txtEdad);
            Controls.Add(lblCarrera);
            Controls.Add(lblEdad);
            Controls.Add(lblNombre);
            Name = "FrmAlumno";
            Text = "Form1";
            grpMatricula.ResumeLayout(false);
            grpMatricula.PerformLayout();
            grpMaterias.ResumeLayout(false);
            grpMaterias.PerformLayout();
            grpGenero.ResumeLayout(false);
            grpGenero.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        //Atributos del contenedor(formulario)
        private Label lblNombre;
        private Label lblEdad;
        private Label lblCarrera;
        private TextBox txtEdad;
        private TextBox txtNombre;
        private ComboBox cmbCarrera;
        private RadioButton rdoFemenino;
        private RadioButton rdoMasculino;
        private RadioButton rdoOtro;
        private CheckBox chkProgramacion;
        private CheckBox chkSistemasOperativos;
        private CheckBox chkModelosSistemas;
        private CheckBox chkMatematicas;
        private Button btnMostrar;
        private RadioButton rdoNo;
        private RadioButton rdoSi;
        private GroupBox grpMatricula;
        private GroupBox grpMaterias;
        private GroupBox grpGenero;
        private TextBox txtDato;
    }
}
