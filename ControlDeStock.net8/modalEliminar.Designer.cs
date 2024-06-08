namespace ControlDeStock.net8
{
    partial class modalEliminar
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
            cbEliminar = new ComboBox();
            btnEliminar = new Button();
            btnNoeliminar = new Button();
            SuspendLayout();
            // 
            // cbEliminar
            // 
            cbEliminar.FormattingEnabled = true;
            cbEliminar.Location = new Point(14, 52);
            cbEliminar.Name = "cbEliminar";
            cbEliminar.Size = new Size(319, 26);
            cbEliminar.TabIndex = 0;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.RoyalBlue;
            btnEliminar.DialogResult = DialogResult.OK;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(14, 181);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(129, 40);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnNoeliminar
            // 
            btnNoeliminar.BackColor = Color.RoyalBlue;
            btnNoeliminar.DialogResult = DialogResult.Cancel;
            btnNoeliminar.FlatAppearance.BorderSize = 0;
            btnNoeliminar.FlatStyle = FlatStyle.Flat;
            btnNoeliminar.ForeColor = Color.White;
            btnNoeliminar.Location = new Point(204, 181);
            btnNoeliminar.Name = "btnNoeliminar";
            btnNoeliminar.Size = new Size(129, 40);
            btnNoeliminar.TabIndex = 3;
            btnNoeliminar.Text = "Deshacer";
            btnNoeliminar.UseVisualStyleBackColor = false;
            // 
            // modalEliminar
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(353, 240);
            Controls.Add(btnNoeliminar);
            Controls.Add(btnEliminar);
            Controls.Add(cbEliminar);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            Name = "modalEliminar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eliminar producto";
            ResumeLayout(false);
        }

        #endregion
        private Button btnEliminar;
        private Button btnNoeliminar;
        public ComboBox cbEliminar;
    }
}