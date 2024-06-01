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
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
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
            groupBox1.Location = new Point(108, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(355, 401);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ventas";
            // 
            // labeloculto1
            // 
            labeloculto1.AutoSize = true;
            labeloculto1.Location = new Point(10, 190);
            labeloculto1.Name = "labeloculto1";
            labeloculto1.Size = new Size(181, 18);
            labeloculto1.TabIndex = 9;
            labeloculto1.Text = "Seleccione un producto";
            labeloculto1.Visible = false;
            // 
            // lblpesos
            // 
            lblpesos.AutoSize = true;
            lblpesos.Location = new Point(170, 58);
            lblpesos.Name = "lblpesos";
            lblpesos.Size = new Size(26, 18);
            lblpesos.TabIndex = 8;
            lblpesos.Text = "kg";
            // 
            // lblkg
            // 
            lblkg.AutoSize = true;
            lblkg.Location = new Point(170, 124);
            lblkg.Name = "lblkg";
            lblkg.Size = new Size(18, 18);
            lblkg.TabIndex = 7;
            lblkg.Text = "$";
            lblkg.Visible = false;
            // 
            // lblMontovendido
            // 
            lblMontovendido.AutoSize = true;
            lblMontovendido.Location = new Point(12, 101);
            lblMontovendido.Name = "lblMontovendido";
            lblMontovendido.Size = new Size(162, 18);
            lblMontovendido.TabIndex = 6;
            lblMontovendido.Text = "Ingresar ventas en $";
            lblMontovendido.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(170, 18);
            label1.TabIndex = 5;
            label1.Text = "Ingresar ventas en kg";
            // 
            // cbSeleccionProducto2
            // 
            cbSeleccionProducto2.FormattingEnabled = true;
            cbSeleccionProducto2.Location = new Point(7, 211);
            cbSeleccionProducto2.Name = "cbSeleccionProducto2";
            cbSeleccionProducto2.Size = new Size(309, 26);
            cbSeleccionProducto2.TabIndex = 4;
            cbSeleccionProducto2.Visible = false;
            cbSeleccionProducto2.SelectedIndexChanged += cbSeleccionProducto2_SelectedIndexChanged;
            // 
            // tbIngresarPrecio
            // 
            tbIngresarPrecio.Location = new Point(12, 122);
            tbIngresarPrecio.Name = "tbIngresarPrecio";
            tbIngresarPrecio.Size = new Size(140, 26);
            tbIngresarPrecio.TabIndex = 3;
            tbIngresarPrecio.Visible = false;
            tbIngresarPrecio.TextChanged += tbIngresarPrecio_TextChanged_1;
            // 
            // tbVentasKg
            // 
            tbVentasKg.Location = new Point(12, 50);
            tbVentasKg.Name = "tbVentasKg";
            tbVentasKg.Size = new Size(140, 26);
            tbVentasKg.TabIndex = 2;
            tbVentasKg.TextChanged += tbVentasKg_TextChanged_1;
            // 
            // btnCancelarVenta
            // 
            btnCancelarVenta.BackColor = Color.RoyalBlue;
            btnCancelarVenta.FlatAppearance.BorderSize = 0;
            btnCancelarVenta.FlatStyle = FlatStyle.Flat;
            btnCancelarVenta.Font = new Font("Verdana", 9F);
            btnCancelarVenta.ForeColor = Color.White;
            btnCancelarVenta.Location = new Point(204, 357);
            btnCancelarVenta.Name = "btnCancelarVenta";
            btnCancelarVenta.Size = new Size(118, 39);
            btnCancelarVenta.TabIndex = 2;
            btnCancelarVenta.Text = "Cancelar";
            btnCancelarVenta.UseVisualStyleBackColor = false;
            // 
            // btnCargarVenta
            // 
            btnCargarVenta.BackColor = Color.RoyalBlue;
            btnCargarVenta.FlatAppearance.BorderSize = 0;
            btnCargarVenta.FlatStyle = FlatStyle.Flat;
            btnCargarVenta.Font = new Font("Verdana", 9F);
            btnCargarVenta.ForeColor = Color.White;
            btnCargarVenta.Location = new Point(6, 357);
            btnCargarVenta.Name = "btnCargarVenta";
            btnCargarVenta.Size = new Size(118, 39);
            btnCargarVenta.TabIndex = 1;
            btnCargarVenta.Text = "Aceptar";
            btnCargarVenta.UseVisualStyleBackColor = false;
            btnCargarVenta.Click += btnCargarVenta_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientInactiveCaption;
            groupBox2.Controls.Add(tbDetalle);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cbSeleccionProducto1);
            groupBox2.Location = new Point(462, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(355, 401);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle";
            // 
            // tbDetalle
            // 
            tbDetalle.Location = new Point(7, 109);
            tbDetalle.Multiline = true;
            tbDetalle.Name = "tbDetalle";
            tbDetalle.ReadOnly = true;
            tbDetalle.Size = new Size(348, 285);
            tbDetalle.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 31);
            label6.Name = "label6";
            label6.Size = new Size(181, 18);
            label6.TabIndex = 10;
            label6.Text = "Seleccione un producto";
            // 
            // cbSeleccionProducto1
            // 
            cbSeleccionProducto1.DropDownHeight = 100;
            cbSeleccionProducto1.FormattingEnabled = true;
            cbSeleccionProducto1.IntegralHeight = false;
            cbSeleccionProducto1.Location = new Point(7, 50);
            cbSeleccionProducto1.Name = "cbSeleccionProducto1";
            cbSeleccionProducto1.Size = new Size(348, 26);
            cbSeleccionProducto1.TabIndex = 5;
            cbSeleccionProducto1.SelectedIndexChanged += cbSeleccionProducto1_SelectedIndexChanged_1;
            // 
            // panelizquierda
            // 
            panelizquierda.BackColor = Color.RoyalBlue;
            panelizquierda.Controls.Add(btnAcercaDe);
            panelizquierda.Controls.Add(btnModificar);
            panelizquierda.Controls.Add(btnEliminar);
            panelizquierda.Controls.Add(btnCargarNuevo);
            panelizquierda.Dock = DockStyle.Left;
            panelizquierda.Location = new Point(0, 0);
            panelizquierda.Name = "panelizquierda";
            panelizquierda.Size = new Size(107, 404);
            panelizquierda.TabIndex = 3;
            // 
            // btnAcercaDe
            // 
            btnAcercaDe.BackColor = Color.RoyalBlue;
            btnAcercaDe.Dock = DockStyle.Bottom;
            btnAcercaDe.FlatAppearance.BorderSize = 0;
            btnAcercaDe.FlatStyle = FlatStyle.Flat;
            btnAcercaDe.Font = new Font("Verdana", 9F);
            btnAcercaDe.ForeColor = SystemColors.ButtonFace;
            btnAcercaDe.Location = new Point(0, 346);
            btnAcercaDe.Name = "btnAcercaDe";
            btnAcercaDe.Size = new Size(107, 58);
            btnAcercaDe.TabIndex = 3;
            btnAcercaDe.Text = "Acerca de";
            btnAcercaDe.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.RoyalBlue;
            btnModificar.Dock = DockStyle.Top;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Verdana", 9F);
            btnModificar.ForeColor = SystemColors.ButtonFace;
            btnModificar.Location = new Point(0, 120);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(107, 60);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar Producto";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.RoyalBlue;
            btnEliminar.Dock = DockStyle.Top;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Verdana", 9F);
            btnEliminar.ForeColor = SystemColors.ButtonFace;
            btnEliminar.Location = new Point(0, 60);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(107, 60);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar Producto";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCargarNuevo
            // 
            btnCargarNuevo.BackColor = Color.RoyalBlue;
            btnCargarNuevo.Dock = DockStyle.Top;
            btnCargarNuevo.FlatAppearance.BorderSize = 0;
            btnCargarNuevo.FlatStyle = FlatStyle.Flat;
            btnCargarNuevo.Font = new Font("Verdana", 9F);
            btnCargarNuevo.ForeColor = SystemColors.ButtonFace;
            btnCargarNuevo.Location = new Point(0, 0);
            btnCargarNuevo.Name = "btnCargarNuevo";
            btnCargarNuevo.Size = new Size(107, 60);
            btnCargarNuevo.TabIndex = 0;
            btnCargarNuevo.Text = "Cargar Producto";
            btnCargarNuevo.UseVisualStyleBackColor = false;
            btnCargarNuevo.Click += button1_Click;
            // 
            // panelderecha
            // 
            panelderecha.BackColor = Color.RoyalBlue;
            panelderecha.Controls.Add(btnGenerarExcel);
            panelderecha.Controls.Add(btnCalcularPorc);
            panelderecha.Dock = DockStyle.Right;
            panelderecha.Location = new Point(823, 0);
            panelderecha.Name = "panelderecha";
            panelderecha.Size = new Size(107, 404);
            panelderecha.TabIndex = 4;
            // 
            // btnGenerarExcel
            // 
            btnGenerarExcel.BackColor = Color.RoyalBlue;
            btnGenerarExcel.Dock = DockStyle.Top;
            btnGenerarExcel.FlatAppearance.BorderSize = 0;
            btnGenerarExcel.FlatStyle = FlatStyle.Flat;
            btnGenerarExcel.Font = new Font("Verdana", 9F);
            btnGenerarExcel.ForeColor = SystemColors.ButtonHighlight;
            btnGenerarExcel.Location = new Point(0, 60);
            btnGenerarExcel.Name = "btnGenerarExcel";
            btnGenerarExcel.Size = new Size(107, 60);
            btnGenerarExcel.TabIndex = 1;
            btnGenerarExcel.Text = "Generar Excel";
            btnGenerarExcel.UseVisualStyleBackColor = false;
            btnGenerarExcel.Click += btnGenerarExcel_Click;
            // 
            // btnCalcularPorc
            // 
            btnCalcularPorc.BackColor = Color.RoyalBlue;
            btnCalcularPorc.Dock = DockStyle.Top;
            btnCalcularPorc.FlatAppearance.BorderSize = 0;
            btnCalcularPorc.FlatStyle = FlatStyle.Flat;
            btnCalcularPorc.Font = new Font("Verdana", 9F);
            btnCalcularPorc.ForeColor = SystemColors.ButtonHighlight;
            btnCalcularPorc.Location = new Point(0, 0);
            btnCalcularPorc.Name = "btnCalcularPorc";
            btnCalcularPorc.Size = new Size(107, 60);
            btnCalcularPorc.TabIndex = 0;
            btnCalcularPorc.Text = "Calcular Porcentaje";
            btnCalcularPorc.UseVisualStyleBackColor = false;
            btnCalcularPorc.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(930, 404);
            Controls.Add(panelderecha);
            Controls.Add(panelizquierda);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
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
        public ComboBox cbSeleccionProducto2;
        public Label labeloculto1;
    }
}
