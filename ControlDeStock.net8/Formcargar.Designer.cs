﻿namespace ControlDeStock.net8
{
    partial class Formcargar
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
            groupBox1 = new GroupBox();
            btnMcancelar = new Button();
            btnMcargar = new Button();
            tbDescripcion = new TextBox();
            tbCantidad = new TextBox();
            tbProducto = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnMcancelar);
            groupBox1.Controls.Add(btnMcargar);
            groupBox1.Controls.Add(tbDescripcion);
            groupBox1.Controls.Add(tbCantidad);
            groupBox1.Controls.Add(tbProducto);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 430);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cargar nuevo producto";
            // 
            // btnMcancelar
            // 
            btnMcancelar.DialogResult = DialogResult.Cancel;
            btnMcancelar.Location = new Point(200, 364);
            btnMcancelar.Name = "btnMcancelar";
            btnMcancelar.Size = new Size(101, 47);
            btnMcancelar.TabIndex = 7;
            btnMcancelar.Text = "Cancelar";
            btnMcancelar.UseVisualStyleBackColor = true;
            // 
            // btnMcargar
            // 
            btnMcargar.DialogResult = DialogResult.Yes;
            btnMcargar.Location = new Point(19, 364);
            btnMcargar.Name = "btnMcargar";
            btnMcargar.Size = new Size(101, 47);
            btnMcargar.TabIndex = 6;
            btnMcargar.Text = "Aceptar";
            btnMcargar.UseVisualStyleBackColor = true;
            // 
            // tbDescripcion
            // 
            tbDescripcion.Location = new Point(19, 207);
            tbDescripcion.Multiline = true;
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(282, 129);
            tbDescripcion.TabIndex = 5;
            // 
            // tbCantidad
            // 
            tbCantidad.Location = new Point(19, 126);
            tbCantidad.Name = "tbCantidad";
            tbCantidad.Size = new Size(125, 27);
            tbCantidad.TabIndex = 4;
            tbCantidad.TextChanged += tbCantidad_TextChanged;
            // 
            // tbProducto
            // 
            tbProducto.Location = new Point(19, 57);
            tbProducto.Name = "tbProducto";
            tbProducto.Size = new Size(125, 27);
            tbProducto.TabIndex = 3;
            tbProducto.TextChanged += tbProducto_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 184);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 103);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 1;
            label2.Text = "Cantidad de kg";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 34);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // Formcargar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 452);
            Controls.Add(groupBox1);
            Name = "Formcargar";
            Text = "Formcargar";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        public Button btnMcargar;
        public TextBox tbDescripcion;
        public TextBox tbCantidad;
        public TextBox tbProducto;
        public Button btnMcancelar;
    }
}