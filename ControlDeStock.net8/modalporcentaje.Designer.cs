namespace ControlDeStock.net8
{
    partial class modalporcentaje
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
            btnCalcular = new Button();
            label1 = new Label();
            tbValorProducto = new TextBox();
            tbPorcentaje = new TextBox();
            label2 = new Label();
            tbResultado = new TextBox();
            label3 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.RoyalBlue;
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(210, 82);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(116, 38);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 39);
            label1.Name = "label1";
            label1.Size = new Size(143, 18);
            label1.TabIndex = 1;
            label1.Text = "Valor del producto";
            // 
            // tbValorProducto
            // 
            tbValorProducto.Location = new Point(14, 59);
            tbValorProducto.Name = "tbValorProducto";
            tbValorProducto.Size = new Size(172, 26);
            tbValorProducto.TabIndex = 2;
            tbValorProducto.TextChanged += tbValorProducto_TextChanged;
            // 
            // tbPorcentaje
            // 
            tbPorcentaje.Location = new Point(14, 122);
            tbPorcentaje.Name = "tbPorcentaje";
            tbPorcentaje.Size = new Size(172, 26);
            tbPorcentaje.TabIndex = 3;
            tbPorcentaje.TextChanged += tbPorcentaje_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 102);
            label2.Name = "label2";
            label2.Size = new Size(175, 18);
            label2.TabIndex = 4;
            label2.Text = "Porcentaje a remarcar";
            // 
            // tbResultado
            // 
            tbResultado.Location = new Point(170, 196);
            tbResultado.Multiline = true;
            tbResultado.Name = "tbResultado";
            tbResultado.ReadOnly = true;
            tbResultado.Size = new Size(172, 25);
            tbResultado.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(170, 176);
            label3.Name = "label3";
            label3.Size = new Size(81, 18);
            label3.TabIndex = 6;
            label3.Text = "Resultado";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.RoyalBlue;
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(14, 236);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(116, 38);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.RoyalBlue;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(210, 236);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(116, 38);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // modalporcentaje
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(352, 284);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label3);
            Controls.Add(tbResultado);
            Controls.Add(label2);
            Controls.Add(tbPorcentaje);
            Controls.Add(tbValorProducto);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            Name = "modalporcentaje";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Calcular porcentaje de venta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAceptar;
        private Button btnCancelar;
        public TextBox tbValorProducto;
        public TextBox tbPorcentaje;
        public TextBox tbResultado;
    }
}