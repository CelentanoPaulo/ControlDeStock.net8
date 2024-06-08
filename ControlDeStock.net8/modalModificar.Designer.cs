namespace ControlDeStock.net8
{
    partial class modalModificar
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
            cbModificar = new ComboBox();
            btnAceptarModif = new Button();
            tbDescripModif = new TextBox();
            tbKgInicialModif = new TextBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCancelarModif = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cbModificar
            // 
            cbModificar.FormattingEnabled = true;
            cbModificar.Location = new Point(7, 51);
            cbModificar.Name = "cbModificar";
            cbModificar.Size = new Size(390, 26);
            cbModificar.TabIndex = 0;
            // 
            // btnAceptarModif
            // 
            btnAceptarModif.BackColor = Color.RoyalBlue;
            btnAceptarModif.DialogResult = DialogResult.OK;
            btnAceptarModif.FlatAppearance.BorderSize = 0;
            btnAceptarModif.FlatStyle = FlatStyle.Flat;
            btnAceptarModif.ForeColor = Color.White;
            btnAceptarModif.Location = new Point(35, 324);
            btnAceptarModif.Name = "btnAceptarModif";
            btnAceptarModif.Size = new Size(125, 40);
            btnAceptarModif.TabIndex = 1;
            btnAceptarModif.Text = "Aceptar";
            btnAceptarModif.UseVisualStyleBackColor = false;
            // 
            // tbDescripModif
            // 
            tbDescripModif.Location = new Point(7, 181);
            tbDescripModif.Multiline = true;
            tbDescripModif.Name = "tbDescripModif";
            tbDescripModif.Size = new Size(390, 128);
            tbDescripModif.TabIndex = 2;
            // 
            // tbKgInicialModif
            // 
            tbKgInicialModif.Location = new Point(7, 116);
            tbKgInicialModif.Name = "tbKgInicialModif";
            tbKgInicialModif.Size = new Size(140, 26);
            tbKgInicialModif.TabIndex = 3;
            tbKgInicialModif.TextChanged += tbKgInicialModif_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnCancelarModif);
            groupBox1.Controls.Add(cbModificar);
            groupBox1.Controls.Add(btnAceptarModif);
            groupBox1.Controls.Add(tbDescripModif);
            groupBox1.Controls.Add(tbKgInicialModif);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(14, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(404, 379);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Modificar producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 160);
            label4.Name = "label4";
            label4.Size = new Size(163, 18);
            label4.TabIndex = 8;
            label4.Text = "Modificar Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 122);
            label3.Name = "label3";
            label3.Size = new Size(26, 18);
            label3.TabIndex = 7;
            label3.Text = "kg";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 95);
            label2.Name = "label2";
            label2.Size = new Size(142, 18);
            label2.TabIndex = 6;
            label2.Text = "Modificar kg Inicial";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 31);
            label1.Name = "label1";
            label1.Size = new Size(181, 18);
            label1.TabIndex = 5;
            label1.Text = "Selecciona un producto";
            // 
            // btnCancelarModif
            // 
            btnCancelarModif.BackColor = Color.RoyalBlue;
            btnCancelarModif.DialogResult = DialogResult.Cancel;
            btnCancelarModif.FlatAppearance.BorderSize = 0;
            btnCancelarModif.FlatStyle = FlatStyle.Flat;
            btnCancelarModif.ForeColor = Color.White;
            btnCancelarModif.Location = new Point(240, 324);
            btnCancelarModif.Name = "btnCancelarModif";
            btnCancelarModif.Size = new Size(125, 40);
            btnCancelarModif.TabIndex = 4;
            btnCancelarModif.Text = "Cancelar";
            btnCancelarModif.UseVisualStyleBackColor = false;
            // 
            // modalModificar
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(438, 407);
            Controls.Add(groupBox1);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            Name = "modalModificar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Modificar producto";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAceptarModif;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button btnCancelarModif;
        public ComboBox cbModificar;
        public TextBox tbDescripModif;
        private Label label4;
        private Label label3;
        public TextBox tbKgInicialModif;
    }
}