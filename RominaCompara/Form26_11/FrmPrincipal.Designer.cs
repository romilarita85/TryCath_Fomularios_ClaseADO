namespace Form26_11
{
    partial class FrmPrincipal
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
            lblDato = new Label();
            btnMostrar = new Button();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblEdad = new Label();
            txtEdad = new TextBox();
            btnOcultar = new Button();
            btnCerrar = new Button();
            btnCrear = new Button();
            btnDesocultar = new Button();
            btnCerrarSec = new Button();
            SuspendLayout();
            // 
            // lblDato
            // 
            lblDato.AutoSize = true;
            lblDato.BackColor = Color.OldLace;
            lblDato.Font = new Font("Segoe UI", 20F);
            lblDato.Location = new Point(555, 65);
            lblDato.Name = "lblDato";
            lblDato.Size = new Size(37, 46);
            lblDato.TabIndex = 6;
            lblDato.Text = ":)";
            // 
            // btnMostrar
            // 
            btnMostrar.Font = new Font("Segoe UI", 15F);
            btnMostrar.Location = new Point(371, 59);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(157, 52);
            btnMostrar.TabIndex = 3;
            btnMostrar.Text = "MOSTRAR";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.InactiveCaption;
            txtNombre.Font = new Font("Segoe UI", 15F);
            txtNombre.ForeColor = SystemColors.WindowText;
            txtNombre.Location = new Point(105, 38);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(242, 41);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(28, 53);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(28, 109);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(43, 20);
            lblEdad.TabIndex = 3;
            lblEdad.Text = "Edad";
            // 
            // txtEdad
            // 
            txtEdad.BackColor = SystemColors.InactiveCaption;
            txtEdad.Font = new Font("Segoe UI", 15F);
            txtEdad.ForeColor = SystemColors.WindowText;
            txtEdad.Location = new Point(105, 94);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(242, 41);
            txtEdad.TabIndex = 2;
            // 
            // btnOcultar
            // 
            btnOcultar.Location = new Point(623, 88);
            btnOcultar.Name = "btnOcultar";
            btnOcultar.Size = new Size(131, 41);
            btnOcultar.TabIndex = 7;
            btnOcultar.Text = "Ocultar";
            btnOcultar.UseVisualStyleBackColor = true;
            btnOcultar.Click += btnOcultar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(371, 147);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(157, 61);
            btnCerrar.TabIndex = 8;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(623, 38);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(131, 41);
            btnCrear.TabIndex = 9;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnDesocultar
            // 
            btnDesocultar.Location = new Point(623, 204);
            btnDesocultar.Name = "btnDesocultar";
            btnDesocultar.Size = new Size(131, 41);
            btnDesocultar.TabIndex = 10;
            btnDesocultar.Text = "Desocultar";
            btnDesocultar.UseVisualStyleBackColor = true;
            btnDesocultar.Click += btnDesocultar_Click;
            // 
            // btnCerrarSec
            // 
            btnCerrarSec.BackColor = Color.AliceBlue;
            btnCerrarSec.Location = new Point(623, 147);
            btnCerrarSec.Name = "btnCerrarSec";
            btnCerrarSec.Size = new Size(131, 39);
            btnCerrarSec.TabIndex = 11;
            btnCerrarSec.Text = "Cerrar";
            btnCerrarSec.UseVisualStyleBackColor = false;
            btnCerrarSec.Click += btnCerrarSec_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(810, 288);
            Controls.Add(btnCerrarSec);
            Controls.Add(btnDesocultar);
            Controls.Add(btnCrear);
            Controls.Add(btnCerrar);
            Controls.Add(btnOcultar);
            Controls.Add(lblEdad);
            Controls.Add(txtEdad);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(btnMostrar);
            Controls.Add(lblDato);
            Name = "FrmPrincipal";
            Text = "Mi primer formulario";
            FormClosing += FrmPrincipal_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDato;
        private Button btnMostrar;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblEdad;
        private TextBox txtEdad;
        private Button btnOcultar;
        private Button btnCerrar;
        private Button btnCrear;
        private Button btnDesocultar;
        private Button btnCerrarSec;
    }
}
