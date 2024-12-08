namespace ClasesyForms28_11
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
            dgwAlumnos = new DataGridView();
            lstAlumnos = new ListBox();
            btnCrear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwAlumnos).BeginInit();
            SuspendLayout();
            // 
            // dgwAlumnos
            // 
            dgwAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwAlumnos.Location = new Point(51, 223);
            dgwAlumnos.Name = "dgwAlumnos";
            dgwAlumnos.RowHeadersWidth = 51;
            dgwAlumnos.Size = new Size(1000, 323);
            dgwAlumnos.TabIndex = 35;
            // 
            // lstAlumnos
            // 
            lstAlumnos.FormattingEnabled = true;
            lstAlumnos.Location = new Point(51, 40);
            lstAlumnos.Name = "lstAlumnos";
            lstAlumnos.Size = new Size(1000, 144);
            lstAlumnos.TabIndex = 34;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(418, 575);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(262, 54);
            btnCrear.TabIndex = 36;
            btnCrear.Text = "Crear alumno";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 661);
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

        private DataGridView dgwAlumnos;
        private ListBox lstAlumnos;
        private Button btnCrear;
    }
}