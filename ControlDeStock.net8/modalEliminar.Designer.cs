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
            cbEliminar.Location = new Point(12, 58);
            cbEliminar.Name = "cbEliminar";
            cbEliminar.Size = new Size(284, 28);
            cbEliminar.TabIndex = 0;
            
            // 
            // btnEliminar
            // 
            btnEliminar.DialogResult = DialogResult.OK;
            btnEliminar.Location = new Point(12, 201);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(115, 44);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnNoeliminar
            // 
            btnNoeliminar.DialogResult = DialogResult.Cancel;
            btnNoeliminar.Location = new Point(181, 201);
            btnNoeliminar.Name = "btnNoeliminar";
            btnNoeliminar.Size = new Size(115, 44);
            btnNoeliminar.TabIndex = 3;
            btnNoeliminar.Text = "Deshacer";
            btnNoeliminar.UseVisualStyleBackColor = true;
            // 
            // modalEliminar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 267);
            Controls.Add(btnNoeliminar);
            Controls.Add(btnEliminar);
            Controls.Add(cbEliminar);
            Name = "modalEliminar";
            Text = "modalEliminar";
            
            ResumeLayout(false);
        }

        #endregion
        private Button btnEliminar;
        private Button btnNoeliminar;
        public ComboBox cbEliminar;
    }
}