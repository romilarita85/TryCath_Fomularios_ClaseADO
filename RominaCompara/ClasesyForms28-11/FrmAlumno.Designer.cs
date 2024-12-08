namespace ClasesyForms28_11
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
            btnCrear = new Button();
            cmbCarrera = new ComboBox();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            lblCarrera = new Label();
            lblEdad = new Label();
            lblNombre = new Label();
            lblId = new Label();
            numId = new NumericUpDown();
            grpMaterias.SuspendLayout();
            grpGenero.SuspendLayout();
            grpMatricula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numId).BeginInit();
            SuspendLayout();
            // 
            // grpMaterias
            // 
            grpMaterias.Controls.Add(chkProgramacion);
            grpMaterias.Controls.Add(chkSistemasOperativos);
            grpMaterias.Controls.Add(chkModelosSistemas);
            grpMaterias.Controls.Add(chkMatematicas);
            grpMaterias.Location = new Point(28, 392);
            grpMaterias.Name = "grpMaterias";
            grpMaterias.Size = new Size(251, 186);
            grpMaterias.TabIndex = 27;
            grpMaterias.TabStop = false;
            grpMaterias.Text = "Materias";
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
            // grpGenero
            // 
            grpGenero.Controls.Add(rdoFemenino);
            grpGenero.Controls.Add(rdoMasculino);
            grpGenero.Controls.Add(rdoOtro);
            grpGenero.Location = new Point(28, 231);
            grpGenero.Name = "grpGenero";
            grpGenero.Size = new Size(251, 145);
            grpGenero.TabIndex = 19;
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
            grpMatricula.Location = new Point(358, 32);
            grpMatricula.Name = "grpMatricula";
            grpMatricula.Size = new Size(126, 104);
            grpMatricula.TabIndex = 28;
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
            // btnCrear
            // 
            btnCrear.Location = new Point(101, 598);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(152, 42);
            btnCrear.TabIndex = 26;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // cmbCarrera
            // 
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Items.AddRange(new object[] { "Tecnicatura en Programacion", "Ingenieria Informatica", "Licenciatura en informatica" });
            cmbCarrera.Location = new Point(150, 169);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(151, 28);
            cmbCarrera.TabIndex = 25;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(150, 71);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(151, 27);
            txtNombre.TabIndex = 24;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(150, 119);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(151, 27);
            txtEdad.TabIndex = 23;
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Location = new Point(28, 177);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(57, 20);
            lblCarrera.TabIndex = 22;
            lblCarrera.Text = "Carrera";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(28, 126);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(43, 20);
            lblEdad.TabIndex = 21;
            lblEdad.Text = "Edad";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(28, 78);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 20;
            lblNombre.Text = "Nombre";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(28, 32);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 20);
            lblId.TabIndex = 30;
            lblId.Text = "Id";
            // 
            // numId
            // 
            numId.Location = new Point(151, 22);
            numId.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numId.Name = "numId";
            numId.Size = new Size(150, 27);
            numId.TabIndex = 31;
            // 
            // FrmAlumno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 664);
            Controls.Add(numId);
            Controls.Add(lblId);
            Controls.Add(grpMaterias);
            Controls.Add(grpGenero);
            Controls.Add(grpMatricula);
            Controls.Add(btnCrear);
            Controls.Add(cmbCarrera);
            Controls.Add(txtNombre);
            Controls.Add(txtEdad);
            Controls.Add(lblCarrera);
            Controls.Add(lblEdad);
            Controls.Add(lblNombre);
            Name = "FrmAlumno";
            Text = "Form1";
            Load += FrmAlumno_Load;
            grpMaterias.ResumeLayout(false);
            grpMaterias.PerformLayout();
            grpGenero.ResumeLayout(false);
            grpGenero.PerformLayout();
            grpMatricula.ResumeLayout(false);
            grpMatricula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Button btnCrear;
        private ComboBox cmbCarrera;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private Label lblCarrera;
        private Label lblEdad;
        private Label lblNombre;
        private Label lblId;
        private NumericUpDown numId;
    }
}
