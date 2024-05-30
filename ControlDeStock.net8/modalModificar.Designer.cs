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
            cbModificar.Location = new Point(6, 57);
            cbModificar.Name = "cbModificar";
            cbModificar.Size = new Size(287, 28);
            cbModificar.TabIndex = 0;
            // 
            // btnAceptarModif
            // 
            btnAceptarModif.DialogResult = DialogResult.OK;
            btnAceptarModif.Location = new Point(6, 360);
            btnAceptarModif.Name = "btnAceptarModif";
            btnAceptarModif.Size = new Size(111, 45);
            btnAceptarModif.TabIndex = 1;
            btnAceptarModif.Text = "Aceptar";
            btnAceptarModif.UseVisualStyleBackColor = true;
            // 
            // tbDescripModif
            // 
            tbDescripModif.Location = new Point(6, 201);
            tbDescripModif.Multiline = true;
            tbDescripModif.Name = "tbDescripModif";
            tbDescripModif.Size = new Size(287, 142);
            tbDescripModif.TabIndex = 2;
            // 
            // tbKgInicialModif
            // 
            tbKgInicialModif.Location = new Point(6, 129);
            tbKgInicialModif.Name = "tbKgInicialModif";
            tbKgInicialModif.Size = new Size(125, 27);
            tbKgInicialModif.TabIndex = 3;
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
            groupBox1.Location = new Point(12, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(359, 421);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Modificar producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 178);
            label4.Name = "label4";
            label4.Size = new Size(155, 20);
            label4.TabIndex = 8;
            label4.Text = "Modificar Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(137, 136);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 7;
            label3.Text = "kg";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 106);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 6;
            label2.Text = "Modificar kg Inicial";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(165, 20);
            label1.TabIndex = 5;
            label1.Text = "Selecciona un producto";
            // 
            // btnCancelarModif
            // 
            btnCancelarModif.DialogResult = DialogResult.Cancel;
            btnCancelarModif.Location = new Point(182, 360);
            btnCancelarModif.Name = "btnCancelarModif";
            btnCancelarModif.Size = new Size(111, 45);
            btnCancelarModif.TabIndex = 4;
            btnCancelarModif.Text = "Cancelar";
            btnCancelarModif.UseVisualStyleBackColor = true;
            // 
            // modalModificar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 452);
            Controls.Add(groupBox1);
            Name = "modalModificar";
            Text = "modalModificar";
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