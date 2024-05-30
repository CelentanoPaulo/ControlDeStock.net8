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
            btnCalcular.Location = new Point(187, 91);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(103, 42);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 1;
            label1.Text = "valor del producto";
            // 
            // tbValorProducto
            // 
            tbValorProducto.Location = new Point(12, 66);
            tbValorProducto.Name = "tbValorProducto";
            tbValorProducto.Size = new Size(153, 27);
            tbValorProducto.TabIndex = 2;
            tbValorProducto.TextChanged += tbValorProducto_TextChanged;
            // 
            // tbPorcentaje
            // 
            tbPorcentaje.Location = new Point(12, 136);
            tbPorcentaje.Name = "tbPorcentaje";
            tbPorcentaje.Size = new Size(153, 27);
            tbPorcentaje.TabIndex = 3;
            tbPorcentaje.TextChanged += tbPorcentaje_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 113);
            label2.Name = "label2";
            label2.Size = new Size(153, 20);
            label2.TabIndex = 4;
            label2.Text = "Porcentaje a remarcar";
            // 
            // tbResultado
            // 
            tbResultado.Location = new Point(151, 218);
            tbResultado.Multiline = true;
            tbResultado.Name = "tbResultado";
            tbResultado.ReadOnly = true;
            tbResultado.Size = new Size(153, 27);
            tbResultado.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 195);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 6;
            label3.Text = "Resultado";
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Location = new Point(12, 262);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(103, 42);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(187, 262);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(103, 42);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // modalporcentaje
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 316);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label3);
            Controls.Add(tbResultado);
            Controls.Add(label2);
            Controls.Add(tbPorcentaje);
            Controls.Add(tbValorProducto);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            Name = "modalporcentaje";
            Text = "modalporcentaje";
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