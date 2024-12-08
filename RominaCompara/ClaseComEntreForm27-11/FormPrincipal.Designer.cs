namespace ClaseComEntreForm27_11
{
    partial class FormPrincipal
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
            txt_numero1 = new TextBox();
            lbl_numero1 = new Label();
            btn_suma = new Button();
            btn_multiplicacion = new Button();
            btn_resta = new Button();
            btn_dividir = new Button();
            lbl_numero2 = new Label();
            txt_numero2 = new TextBox();
            SuspendLayout();
            // 
            // txt_numero1
            // 
            txt_numero1.Location = new Point(122, 56);
            txt_numero1.Name = "txt_numero1";
            txt_numero1.PlaceholderText = "Ingrese el primer operando";
            txt_numero1.Size = new Size(213, 27);
            txt_numero1.TabIndex = 0;
            // 
            // lbl_numero1
            // 
            lbl_numero1.AutoSize = true;
            lbl_numero1.Location = new Point(41, 59);
            lbl_numero1.Name = "lbl_numero1";
            lbl_numero1.Size = new Size(75, 20);
            lbl_numero1.TabIndex = 2;
            lbl_numero1.Text = "Numero 1";
            // 
            // btn_suma
            // 
            btn_suma.Font = new Font("Segoe UI", 15F);
            btn_suma.Location = new Point(167, 125);
            btn_suma.Name = "btn_suma";
            btn_suma.Size = new Size(116, 44);
            btn_suma.TabIndex = 4;
            btn_suma.Text = "+";
            btn_suma.UseVisualStyleBackColor = true;
            btn_suma.Click += btn_suma_Click;
            // 
            // btn_multiplicacion
            // 
            btn_multiplicacion.Font = new Font("Segoe UI", 15F);
            btn_multiplicacion.Location = new Point(419, 125);
            btn_multiplicacion.Name = "btn_multiplicacion";
            btn_multiplicacion.Size = new Size(116, 44);
            btn_multiplicacion.TabIndex = 5;
            btn_multiplicacion.Text = "*";
            btn_multiplicacion.UseVisualStyleBackColor = true;
            btn_multiplicacion.Click += btn_multiplicacion_Click;
            // 
            // btn_resta
            // 
            btn_resta.Font = new Font("Segoe UI", 15F);
            btn_resta.Location = new Point(167, 186);
            btn_resta.Name = "btn_resta";
            btn_resta.Size = new Size(116, 44);
            btn_resta.TabIndex = 6;
            btn_resta.Text = "-";
            btn_resta.UseVisualStyleBackColor = true;
            btn_resta.Click += btn_resta_Click;
            // 
            // btn_dividir
            // 
            btn_dividir.Font = new Font("Segoe UI", 15F);
            btn_dividir.Location = new Point(419, 186);
            btn_dividir.Name = "btn_dividir";
            btn_dividir.Size = new Size(116, 44);
            btn_dividir.TabIndex = 7;
            btn_dividir.Text = "/";
            btn_dividir.UseVisualStyleBackColor = true;
            btn_dividir.Click += btn_dividir_Click;
            // 
            // lbl_numero2
            // 
            lbl_numero2.AutoSize = true;
            lbl_numero2.Location = new Point(382, 63);
            lbl_numero2.Name = "lbl_numero2";
            lbl_numero2.Size = new Size(75, 20);
            lbl_numero2.TabIndex = 9;
            lbl_numero2.Text = "Numero 2";
            // 
            // txt_numero2
            // 
            txt_numero2.Location = new Point(468, 56);
            txt_numero2.Name = "txt_numero2";
            txt_numero2.PlaceholderText = "Ingrese el segundo operando";
            txt_numero2.Size = new Size(213, 27);
            txt_numero2.TabIndex = 8;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 270);
            Controls.Add(lbl_numero2);
            Controls.Add(txt_numero2);
            Controls.Add(btn_dividir);
            Controls.Add(btn_resta);
            Controls.Add(btn_multiplicacion);
            Controls.Add(btn_suma);
            Controls.Add(lbl_numero1);
            Controls.Add(txt_numero1);
            Name = "FormPrincipal";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_numero1;
        private Label lbl_numero1;
        private Button btn_suma;
        private Button btn_multiplicacion;
        private Button btn_resta;
        private Button btn_dividir;
        private Label lbl_numero2;
        private TextBox txt_numero2;
    }
}
