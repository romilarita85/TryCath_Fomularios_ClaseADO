namespace ClasesyForms03_12
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
            btnCrear = new Button();
            dgwAlumnos = new DataGridView();
            lstAlumnos = new ListBox();
            btnModificar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwAlumnos).BeginInit();
            SuspendLayout();
            // 
            // btnCrear
            // 
            btnCrear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnCrear.Location = new Point(60, 582);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(226, 54);
            btnCrear.TabIndex = 39;
            btnCrear.Text = "Crear alumno";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // dgwAlumnos
            // 
            dgwAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwAlumnos.Location = new Point(45, 223);
            dgwAlumnos.Name = "dgwAlumnos";
            dgwAlumnos.RowHeadersWidth = 51;
            dgwAlumnos.Size = new Size(965, 323);
            dgwAlumnos.TabIndex = 38;
            // 
            // lstAlumnos
            // 
            lstAlumnos.FormattingEnabled = true;
            lstAlumnos.Location = new Point(45, 40);
            lstAlumnos.Name = "lstAlumnos";
            lstAlumnos.Size = new Size(965, 144);
            lstAlumnos.TabIndex = 37;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnModificar.Location = new Point(407, 582);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(226, 54);
            btnModificar.TabIndex = 40;
            btnModificar.Text = "Modificar alumno";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnEliminar.Location = new Point(763, 582);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(226, 54);
            btnEliminar.TabIndex = 41;
            btnEliminar.Text = "Eliminar alumno";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 668);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnCrear);
            Controls.Add(dgwAlumnos);
            Controls.Add(lstAlumnos);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgwAlumnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCrear;
        private DataGridView dgwAlumnos;
        private ListBox lstAlumnos;
        private Button btnModificar;
        private Button btnEliminar;
    }
}