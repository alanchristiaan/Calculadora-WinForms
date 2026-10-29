namespace Calculadora
{
    partial class frmCalculadora
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
            txtNumeros = new TextBox();
            btnSumar = new Button();
            btnRestar = new Button();
            btnPotencia = new Button();
            btnRaizCuadrada = new Button();
            btnDividir = new Button();
            btnMultiplicar = new Button();
            btnLogaritmo = new Button();
            btnLimpiar = new Button();
            btnBorrar = new Button();
            lblCalculadora = new Label();
            btnIgual = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(62, 87);
            txtNumeros.Multiline = true;
            txtNumeros.Name = "txtNumeros";
            txtNumeros.RightToLeft = RightToLeft.Yes;
            txtNumeros.Size = new Size(376, 53);
            txtNumeros.TabIndex = 0;
            // 
            // btnSumar
            // 
            btnSumar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSumar.Location = new Point(62, 146);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(40, 39);
            btnSumar.TabIndex = 1;
            btnSumar.Text = "+";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click_1;
            // 
            // btnRestar
            // 
            btnRestar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestar.Location = new Point(108, 146);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(40, 39);
            btnRestar.TabIndex = 2;
            btnRestar.Text = "-";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += btnRestar_Click;
            // 
            // btnPotencia
            // 
            btnPotencia.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPotencia.Location = new Point(302, 146);
            btnPotencia.Name = "btnPotencia";
            btnPotencia.Size = new Size(65, 39);
            btnPotencia.TabIndex = 3;
            btnPotencia.Text = "pow";
            btnPotencia.UseVisualStyleBackColor = true;
            btnPotencia.Click += btnPotencia_Click;
            // 
            // btnRaizCuadrada
            // 
            btnRaizCuadrada.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRaizCuadrada.Location = new Point(246, 146);
            btnRaizCuadrada.Name = "btnRaizCuadrada";
            btnRaizCuadrada.Size = new Size(50, 39);
            btnRaizCuadrada.TabIndex = 4;
            btnRaizCuadrada.Text = "sqr";
            btnRaizCuadrada.UseVisualStyleBackColor = true;
            btnRaizCuadrada.Click += btnRaizCuadrada_Click;
            // 
            // btnDividir
            // 
            btnDividir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDividir.Location = new Point(200, 146);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(40, 39);
            btnDividir.TabIndex = 5;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiplicar.Location = new Point(154, 146);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(40, 39);
            btnMultiplicar.TabIndex = 6;
            btnMultiplicar.Text = "*";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnLogaritmo
            // 
            btnLogaritmo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogaritmo.Location = new Point(373, 148);
            btnLogaritmo.Name = "btnLogaritmo";
            btnLogaritmo.Size = new Size(65, 39);
            btnLogaritmo.TabIndex = 7;
            btnLogaritmo.Text = "log()";
            btnLogaritmo.UseVisualStyleBackColor = true;
            btnLogaritmo.Click += btnLogaritmo_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(62, 191);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 39);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "CLEAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrar.Location = new Point(178, 191);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(110, 39);
            btnBorrar.TabIndex = 9;
            btnBorrar.Text = "DELETE";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // lblCalculadora
            // 
            lblCalculadora.BackColor = SystemColors.ActiveCaptionText;
            lblCalculadora.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCalculadora.ForeColor = SystemColors.Control;
            lblCalculadora.Location = new Point(64, 9);
            lblCalculadora.Name = "lblCalculadora";
            lblCalculadora.Size = new Size(374, 36);
            lblCalculadora.TabIndex = 10;
            lblCalculadora.Text = "Calculadora";
            // 
            // btnIgual
            // 
            btnIgual.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIgual.Location = new Point(294, 191);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(144, 39);
            btnIgual.TabIndex = 11;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // lblResultado
            // 
            lblResultado.BackColor = SystemColors.ActiveCaptionText;
            lblResultado.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.ForeColor = SystemColors.Control;
            lblResultado.Location = new Point(62, 233);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(374, 36);
            lblResultado.TabIndex = 12;
            lblResultado.Text = "Resultado";
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnIgual);
            Controls.Add(lblCalculadora);
            Controls.Add(btnBorrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnLogaritmo);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnDividir);
            Controls.Add(btnRaizCuadrada);
            Controls.Add(btnPotencia);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Controls.Add(txtNumeros);
            Name = "frmCalculadora";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumeros;
        private Button btnSumar;
        private Button btnRestar;
        private Button btnPotencia;
        private Button btnRaizCuadrada;
        private Button btnDividir;
        private Button btnMultiplicar;
        private Button btnLogaritmo;
        private Button btnLimpiar;
        private Button btnBorrar;
        private Label lblCalculadora;
        private Button btnIgual;
        private Label lblResultado;
    }
}
