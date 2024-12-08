namespace FormsClaseAdo03_12
{
    partial class FrmPrincipal
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
            btnEliminar = new Button();
            btnModificar = new Button();
            btnCrear = new Button();
            dgwAlumnos = new DataGridView();
            lstAlumnos = new ListBox();
            btnEstadistica = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwAlumnos).BeginInit();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnEliminar.Location = new Point(529, 575);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(191, 54);
            btnEliminar.TabIndex = 46;
            btnEliminar.Text = "Eliminar alumno";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnModificar.Location = new Point(285, 575);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(191, 54);
            btnModificar.TabIndex = 45;
            btnModificar.Text = "Modificar alumno";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnCrear
            // 
            btnCrear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnCrear.Location = new Point(46, 575);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(191, 54);
            btnCrear.TabIndex = 44;
            btnCrear.Text = "Crear alumno";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // dgwAlumnos
            // 
            dgwAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwAlumnos.Location = new Point(31, 216);
            dgwAlumnos.Name = "dgwAlumnos";
            dgwAlumnos.RowHeadersWidth = 51;
            dgwAlumnos.Size = new Size(965, 323);
            dgwAlumnos.TabIndex = 43;
            // 
            // lstAlumnos
            // 
            lstAlumnos.FormattingEnabled = true;
            lstAlumnos.Location = new Point(31, 33);
            lstAlumnos.Name = "lstAlumnos";
            lstAlumnos.Size = new Size(965, 144);
            lstAlumnos.TabIndex = 42;
            // 
            // btnEstadistica
            // 
            btnEstadistica.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnEstadistica.Location = new Point(788, 575);
            btnEstadistica.Name = "btnEstadistica";
            btnEstadistica.Size = new Size(177, 54);
            btnEstadistica.TabIndex = 47;
            btnEstadistica.Text = "Estadistica";
            btnEstadistica.UseVisualStyleBackColor = true;
            btnEstadistica.Click += btnEstadistica_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 657);
            Controls.Add(btnEstadistica);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnCrear);
            Controls.Add(dgwAlumnos);
            Controls.Add(lstAlumnos);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            Click += FrmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgwAlumnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEliminar;
        private Button btnModificar;
        private Button btnCrear;
        private DataGridView dgwAlumnos;
        private ListBox lstAlumnos;
        private Button btnEstadistica;
    }
}