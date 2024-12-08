namespace Form26_11
{
    partial class FrmPrueba
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
            lblPrueba = new Label();
            SuspendLayout();
            // 
            // lblPrueba
            // 
            lblPrueba.AutoSize = true;
            lblPrueba.Font = new Font("Segoe UI", 25F);
            lblPrueba.Location = new Point(112, 58);
            lblPrueba.Name = "lblPrueba";
            lblPrueba.Size = new Size(156, 57);
            lblPrueba.TabIndex = 0;
            lblPrueba.Text = "Prueba";
            // 
            // FrmPrueba
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 168);
            Controls.Add(lblPrueba);
            Name = "FrmPrueba";
            Text = "FrmPrueba";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrueba;
    }
}