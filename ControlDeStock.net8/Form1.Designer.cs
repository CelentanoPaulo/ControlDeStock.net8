namespace ControlDeStock.net8
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            generarExcelToolStripMenuItem = new ToolStripMenuItem();
            verHistorialToolStripMenuItem = new ToolStripMenuItem();
            edicionToolStripMenuItem = new ToolStripMenuItem();
            cargarNuevoProductoToolStripMenuItem = new ToolStripMenuItem();
            eliminarProductoToolStripMenuItem = new ToolStripMenuItem();
            modificarActualizarProductoToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            labeloculto1 = new Label();
            lblpesos = new Label();
            lblkg = new Label();
            lblMontovendido = new Label();
            label1 = new Label();
            cbSeleccionProducto2 = new ComboBox();
            tbIngresarPrecio = new TextBox();
            tbVentasKg = new TextBox();
            btnCancelarVenta = new Button();
            btnCargarVenta = new Button();
            groupBox2 = new GroupBox();
            tbDetalle = new TextBox();
            label6 = new Label();
            cbSeleccionProducto1 = new ComboBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, edicionToolStripMenuItem, acercaDeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(654, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { guardarToolStripMenuItem, generarExcelToolStripMenuItem, verHistorialToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(182, 26);
            guardarToolStripMenuItem.Text = "Guardar";
            // 
            // generarExcelToolStripMenuItem
            // 
            generarExcelToolStripMenuItem.Name = "generarExcelToolStripMenuItem";
            generarExcelToolStripMenuItem.Size = new Size(182, 26);
            generarExcelToolStripMenuItem.Text = "Generar Excel";
            // 
            // verHistorialToolStripMenuItem
            // 
            verHistorialToolStripMenuItem.Name = "verHistorialToolStripMenuItem";
            verHistorialToolStripMenuItem.Size = new Size(182, 26);
            verHistorialToolStripMenuItem.Text = "Ver Historial";
            // 
            // edicionToolStripMenuItem
            // 
            edicionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cargarNuevoProductoToolStripMenuItem, eliminarProductoToolStripMenuItem, modificarActualizarProductoToolStripMenuItem });
            edicionToolStripMenuItem.Name = "edicionToolStripMenuItem";
            edicionToolStripMenuItem.Size = new Size(72, 24);
            edicionToolStripMenuItem.Text = "Edicion";
            // 
            // cargarNuevoProductoToolStripMenuItem
            // 
            cargarNuevoProductoToolStripMenuItem.Name = "cargarNuevoProductoToolStripMenuItem";
            cargarNuevoProductoToolStripMenuItem.Size = new Size(301, 26);
            cargarNuevoProductoToolStripMenuItem.Text = "Cargar nuevo producto";
            cargarNuevoProductoToolStripMenuItem.Click += cargarNuevoProductoToolStripMenuItem_Click_1;
            // 
            // eliminarProductoToolStripMenuItem
            // 
            eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            eliminarProductoToolStripMenuItem.Size = new Size(301, 26);
            eliminarProductoToolStripMenuItem.Text = "Eliminar producto";
            // 
            // modificarActualizarProductoToolStripMenuItem
            // 
            modificarActualizarProductoToolStripMenuItem.Name = "modificarActualizarProductoToolStripMenuItem";
            modificarActualizarProductoToolStripMenuItem.Size = new Size(301, 26);
            modificarActualizarProductoToolStripMenuItem.Text = "Modificar / Actualizar producto";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(89, 24);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labeloculto1);
            groupBox1.Controls.Add(lblpesos);
            groupBox1.Controls.Add(lblkg);
            groupBox1.Controls.Add(lblMontovendido);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbSeleccionProducto2);
            groupBox1.Controls.Add(tbIngresarPrecio);
            groupBox1.Controls.Add(tbVentasKg);
            groupBox1.Controls.Add(btnCancelarVenta);
            groupBox1.Controls.Add(btnCargarVenta);
            groupBox1.Location = new Point(24, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(295, 380);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ventas";
            // 
            // labeloculto1
            // 
            labeloculto1.AutoSize = true;
            labeloculto1.Location = new Point(34, 185);
            labeloculto1.Name = "labeloculto1";
            labeloculto1.Size = new Size(165, 20);
            labeloculto1.TabIndex = 9;
            labeloculto1.Text = "Seleccione un producto";
            labeloculto1.Visible = false;
            // 
            // lblpesos
            // 
            lblpesos.AutoSize = true;
            lblpesos.Location = new Point(165, 64);
            lblpesos.Name = "lblpesos";
            lblpesos.Size = new Size(25, 20);
            lblpesos.TabIndex = 8;
            lblpesos.Text = "kg";
            // 
            // lblkg
            // 
            lblkg.AutoSize = true;
            lblkg.Location = new Point(11, 142);
            lblkg.Name = "lblkg";
            lblkg.Size = new Size(17, 20);
            lblkg.TabIndex = 7;
            lblkg.Text = "$";
            lblkg.Visible = false;
            // 
            // lblMontovendido
            // 
            lblMontovendido.AutoSize = true;
            lblMontovendido.Location = new Point(34, 112);
            lblMontovendido.Name = "lblMontovendido";
            lblMontovendido.Size = new Size(140, 20);
            lblMontovendido.TabIndex = 6;
            lblMontovendido.Text = "Ingresar ventas en $";
            lblMontovendido.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 34);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 5;
            label1.Text = "Ingresar ventas en kg";
            // 
            // cbSeleccionProducto2
            // 
            cbSeleccionProducto2.FormattingEnabled = true;
            cbSeleccionProducto2.Location = new Point(34, 208);
            cbSeleccionProducto2.Name = "cbSeleccionProducto2";
            cbSeleccionProducto2.Size = new Size(242, 28);
            cbSeleccionProducto2.TabIndex = 4;
            cbSeleccionProducto2.Visible = false;
            // 
            // tbIngresarPrecio
            // 
            tbIngresarPrecio.Location = new Point(34, 135);
            tbIngresarPrecio.Name = "tbIngresarPrecio";
            tbIngresarPrecio.Size = new Size(125, 27);
            tbIngresarPrecio.TabIndex = 3;
            tbIngresarPrecio.Visible = false;
            tbIngresarPrecio.TextChanged += tbIngresarPrecio_TextChanged_1;
            // 
            // tbVentasKg
            // 
            tbVentasKg.Location = new Point(34, 57);
            tbVentasKg.Name = "tbVentasKg";
            tbVentasKg.Size = new Size(125, 27);
            tbVentasKg.TabIndex = 2;
            tbVentasKg.TextChanged += tbVentasKg_TextChanged_1;
            // 
            // btnCancelarVenta
            // 
            btnCancelarVenta.Location = new Point(156, 327);
            btnCancelarVenta.Name = "btnCancelarVenta";
            btnCancelarVenta.Size = new Size(105, 43);
            btnCancelarVenta.TabIndex = 1;
            btnCancelarVenta.Text = "Cancelar";
            btnCancelarVenta.UseVisualStyleBackColor = true;
            // 
            // btnCargarVenta
            // 
            btnCargarVenta.Location = new Point(19, 327);
            btnCargarVenta.Name = "btnCargarVenta";
            btnCargarVenta.Size = new Size(105, 43);
            btnCargarVenta.TabIndex = 0;
            btnCargarVenta.Text = "Aceptar";
            btnCargarVenta.UseVisualStyleBackColor = true;
            btnCargarVenta.Click += btnCargarVenta_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbDetalle);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cbSeleccionProducto1);
            groupBox2.Location = new Point(346, 58);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(295, 380);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle";
            // 
            // tbDetalle
            // 
            tbDetalle.Location = new Point(6, 121);
            tbDetalle.Multiline = true;
            tbDetalle.Name = "tbDetalle";
            tbDetalle.Size = new Size(283, 253);
            tbDetalle.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 34);
            label6.Name = "label6";
            label6.Size = new Size(165, 20);
            label6.TabIndex = 10;
            label6.Text = "Seleccione un producto";
            // 
            // cbSeleccionProducto1
            // 
            cbSeleccionProducto1.FormattingEnabled = true;
            cbSeleccionProducto1.Location = new Point(6, 56);
            cbSeleccionProducto1.Name = "cbSeleccionProducto1";
            cbSeleccionProducto1.Size = new Size(283, 28);
            cbSeleccionProducto1.TabIndex = 5;
            cbSeleccionProducto1.SelectedIndexChanged += cbSeleccionProducto1_SelectedIndexChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 449);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed_1;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem generarExcelToolStripMenuItem;
        private ToolStripMenuItem verHistorialToolStripMenuItem;
        private ToolStripMenuItem edicionToolStripMenuItem;
        private ToolStripMenuItem cargarNuevoProductoToolStripMenuItem;
        private ToolStripMenuItem eliminarProductoToolStripMenuItem;
        private ToolStripMenuItem modificarActualizarProductoToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private GroupBox groupBox1;
        private Button btnCancelarVenta;
        private Button btnCargarVenta;
        private GroupBox groupBox2;
        private TextBox tbIngresarPrecio;
        private TextBox tbVentasKg;
        private Label lblkg;
        private Label lblMontovendido;
        private Label label1;
        private ComboBox cbSeleccionProducto2;
        private Label labeloculto1;
        private Label lblpesos;
        private Label label6;
        private ComboBox cbSeleccionProducto1;
        private TextBox tbDetalle;
    }
}
