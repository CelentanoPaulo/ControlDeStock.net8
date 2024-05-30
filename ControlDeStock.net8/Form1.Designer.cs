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
            panelizquierda = new Panel();
            btnAcercaDe = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnCargarNuevo = new Button();
            panelderecha = new Panel();
            btnGenerarExcel = new Button();
            btnCalcularPorc = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panelizquierda.SuspendLayout();
            panelderecha.SuspendLayout();
            SuspendLayout();
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
            groupBox1.Location = new Point(90, 46);
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
            groupBox2.Location = new Point(412, 46);
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
            cbSeleccionProducto1.DropDownHeight = 100;
            cbSeleccionProducto1.FormattingEnabled = true;
            cbSeleccionProducto1.IntegralHeight = false;
            cbSeleccionProducto1.Location = new Point(6, 56);
            cbSeleccionProducto1.Name = "cbSeleccionProducto1";
            cbSeleccionProducto1.Size = new Size(283, 28);
            cbSeleccionProducto1.TabIndex = 5;
            cbSeleccionProducto1.SelectedIndexChanged += cbSeleccionProducto1_SelectedIndexChanged_1;
            // 
            // panelizquierda
            // 
            panelizquierda.BackColor = Color.Navy;
            panelizquierda.Controls.Add(btnAcercaDe);
            panelizquierda.Controls.Add(btnModificar);
            panelizquierda.Controls.Add(btnEliminar);
            panelizquierda.Controls.Add(btnCargarNuevo);
            panelizquierda.Dock = DockStyle.Left;
            panelizquierda.Location = new Point(0, 0);
            panelizquierda.Name = "panelizquierda";
            panelizquierda.Size = new Size(95, 449);
            panelizquierda.TabIndex = 3;
            // 
            // btnAcercaDe
            // 
            btnAcercaDe.BackColor = Color.Navy;
            btnAcercaDe.Dock = DockStyle.Bottom;
            btnAcercaDe.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAcercaDe.ForeColor = SystemColors.ButtonFace;
            btnAcercaDe.Location = new Point(0, 385);
            btnAcercaDe.Name = "btnAcercaDe";
            btnAcercaDe.Size = new Size(95, 64);
            btnAcercaDe.TabIndex = 3;
            btnAcercaDe.Text = "Acerca de";
            btnAcercaDe.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Navy;
            btnModificar.Dock = DockStyle.Top;
            btnModificar.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = SystemColors.ButtonFace;
            btnModificar.Location = new Point(0, 129);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(95, 62);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar Producto";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Navy;
            btnEliminar.Dock = DockStyle.Top;
            btnEliminar.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.ButtonFace;
            btnEliminar.Location = new Point(0, 66);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(95, 63);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar Producto";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCargarNuevo
            // 
            btnCargarNuevo.BackColor = Color.Navy;
            btnCargarNuevo.Dock = DockStyle.Top;
            btnCargarNuevo.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCargarNuevo.ForeColor = SystemColors.ButtonFace;
            btnCargarNuevo.Location = new Point(0, 0);
            btnCargarNuevo.Name = "btnCargarNuevo";
            btnCargarNuevo.Size = new Size(95, 66);
            btnCargarNuevo.TabIndex = 0;
            btnCargarNuevo.Text = "Cargar Producto";
            btnCargarNuevo.UseVisualStyleBackColor = false;
            btnCargarNuevo.Click += button1_Click;
            // 
            // panelderecha
            // 
            panelderecha.BackColor = Color.Navy;
            panelderecha.Controls.Add(btnGenerarExcel);
            panelderecha.Controls.Add(btnCalcularPorc);
            panelderecha.Dock = DockStyle.Right;
            panelderecha.Location = new Point(725, 0);
            panelderecha.Name = "panelderecha";
            panelderecha.Size = new Size(102, 449);
            panelderecha.TabIndex = 4;
            // 
            // btnGenerarExcel
            // 
            btnGenerarExcel.BackColor = Color.Navy;
            btnGenerarExcel.Dock = DockStyle.Top;
            btnGenerarExcel.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerarExcel.ForeColor = SystemColors.ButtonHighlight;
            btnGenerarExcel.Location = new Point(0, 66);
            btnGenerarExcel.Name = "btnGenerarExcel";
            btnGenerarExcel.Size = new Size(102, 63);
            btnGenerarExcel.TabIndex = 1;
            btnGenerarExcel.Text = "Generar Excel";
            btnGenerarExcel.UseVisualStyleBackColor = false;
            btnGenerarExcel.Click += btnGenerarExcel_Click;
            // 
            // btnCalcularPorc
            // 
            btnCalcularPorc.BackColor = Color.Navy;
            btnCalcularPorc.Dock = DockStyle.Top;
            btnCalcularPorc.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcularPorc.ForeColor = SystemColors.ButtonHighlight;
            btnCalcularPorc.Location = new Point(0, 0);
            btnCalcularPorc.Name = "btnCalcularPorc";
            btnCalcularPorc.Size = new Size(102, 66);
            btnCalcularPorc.TabIndex = 0;
            btnCalcularPorc.Text = "Calcular Porcentaje";
            btnCalcularPorc.UseVisualStyleBackColor = false;
            btnCalcularPorc.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(827, 449);
            Controls.Add(panelderecha);
            Controls.Add(panelizquierda);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Control De Stock";
            FormClosed += Form1_FormClosed_1;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panelizquierda.ResumeLayout(false);
            panelderecha.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
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
        private Panel panelizquierda;
        private Panel panelderecha;
        private Button btnCargarNuevo;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAcercaDe;
        private Button btnCalcularPorc;
        private Button btnGenerarExcel;
    }
}
