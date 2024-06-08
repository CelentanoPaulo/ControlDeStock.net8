using System.Text.Json;
using Newtonsoft.Json;

namespace ControlDeStock.net8
{
    public partial class Form1 : Form
    {
        Sistema miSistema;
        modalModificar miModalModificar = new modalModificar();
        modalEliminar miModalEliminar = new modalEliminar();
        private Button currentBtn;
        private Panel leftBorderBtn;
        private Button currentBtnDerecha;
        private Panel leftBorderBtnDerecha;
        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelizquierda.Controls.Add(leftBorderBtn);

            leftBorderBtnDerecha = new Panel();
            leftBorderBtnDerecha.Size = new Size(7, 60);
            panelderecha.Controls.Add(leftBorderBtnDerecha);


            btnCargarNuevo.FlatStyle = FlatStyle.Flat;
            btnCargarNuevo.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnCalcularPorc.FlatStyle = FlatStyle.Flat;
            btnCalcularPorc.FlatAppearance.BorderSize = 0;
            btnGenerarExcel.FlatStyle = FlatStyle.Flat;
            btnGenerarExcel.FlatAppearance.BorderSize = 0;
            btnAcercaDe.FlatStyle = FlatStyle.Flat;
            btnAcercaDe.FlatAppearance.BorderSize = 0;

        }


        public void Actualizarformulario()
        {
            cbSeleccionProducto1.Items.Clear();
            cbSeleccionProducto2.Items.Clear();
            miModalModificar.cbModificar.Items.Clear();
            miModalEliminar.cbEliminar.Items.Clear();
            foreach (Producto p in miSistema.Productos)
            {
                cbSeleccionProducto1.Items.Add(p.Nombre);
                cbSeleccionProducto2.Items.Add(p.Nombre);
                miModalEliminar.cbEliminar.Items.Add(p.Nombre);
                miModalModificar.cbModificar.Items.Add(p.Nombre);


            }

        }

        public void FormatoMoneda(System.Windows.Forms.TextBox tb)
        {

            if (tb.Text == string.Empty)
            {
                return;
            }
            else
            {

                decimal monto = Convert.ToDecimal(tb.Text);
                tb.Text = monto.ToString("N2");

            }


        }



        private void btnCargarVenta_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbVentasKg.Text) || string.IsNullOrWhiteSpace(tbIngresarPrecio.Text) || cbSeleccionProducto2.SelectedIndex == -1)
            {
                MessageBox.Show("Debe completar todos los campos y seleccionar un producto.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                decimal ganancias = Convert.ToDecimal(tbIngresarPrecio.Text);
                string resultado = ganancias.ToString("N");
                double venta = Convert.ToDouble(tbVentasKg.Text);
                int indice = cbSeleccionProducto2.SelectedIndex;
                Producto producto = miSistema.Productos[indice];
                DialogResult result = MessageBox.Show("Por favor verifique los datos: \nProducto: " + producto.Nombre + "\nMonto en $: " + resultado + "\ny Cantidad Kg: " + venta, "Confirmar Datos", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    producto.GenerarVenta(venta);
                    producto.AcumularGanancias(ganancias);
                    tbIngresarPrecio.Text = "0";
                    tbVentasKg.Text = "0";
                }
            }
        }

        private void cbSeleccionProducto1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            int indice = cbSeleccionProducto1.SelectedIndex;
            Producto producto = miSistema.Productos[indice];
            tbDetalle.Text = producto.ReturnDetalle();

        }

        private void tbIngresarPrecio_TextChanged_1(object sender, EventArgs e)
        {
            ValidarFormatoTextBoxDecimal(sender, e);
            FormatoMoneda(tbIngresarPrecio);


            if (!string.IsNullOrEmpty(tbIngresarPrecio.Text))
            {
                tbIngresarPrecio.Select(tbIngresarPrecio.Text.Length - 3, 0);
                labeloculto1.Visible = true;
                cbSeleccionProducto2.Visible = true;
            }
            else
            {
                labeloculto1.Visible = false;
                cbSeleccionProducto2.Visible = false;
            }
        }

        private void tbVentasKg_TextChanged_1(object sender, EventArgs e)
        {
            ValidarFormatoTextBoxDecimal(sender, e);

            if (!string.IsNullOrEmpty(tbVentasKg.Text))
            {

                lblkg.Visible = true;
                lblMontovendido.Visible = true;
                tbIngresarPrecio.Visible = true;

            }
            else
            {

                lblkg.Visible = false;
                lblMontovendido.Visible = false;
                tbIngresarPrecio.Visible = false;
                labeloculto1.Visible = false;
                cbSeleccionProducto2.Visible = false;
            }


        }

        string archivoInicial = Application.StartupPath + "data.json";
        private void Form1_Load(object sender, EventArgs e)
        {


            if (File.Exists(archivoInicial))
            {
                string rjson = File.ReadAllText("data.json");

                miSistema = JsonConvert.DeserializeObject<Sistema>(rjson);


            }
            if (miSistema == null)
            {
                miSistema = new Sistema();
            }
            Actualizarformulario();


        }
        private void Form1_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            string objJson = JsonConvert.SerializeObject(miSistema);
            File.WriteAllText("data.json", objJson);

        }



        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = Color.FromArgb(36, 44, 79);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleRight;
                //currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = Color.Wheat;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Current Child Form Icon
                //iconCurrentChildForm.IconChar = currentBtn.IconChar;
                //iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.RoyalBlue;
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                //currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void ActivateButtonDerecha(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButtonDerecha();
                currentBtnDerecha = (Button)senderBtn;
                currentBtnDerecha.BackColor = Color.FromArgb(36, 44, 79);
                currentBtnDerecha.ForeColor = Color.White;
                currentBtnDerecha.TextAlign = ContentAlignment.MiddleLeft;
                currentBtnDerecha.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtnDerecha.ImageAlign = ContentAlignment.MiddleLeft;

                leftBorderBtnDerecha.BackColor = Color.Wheat;
                leftBorderBtnDerecha.Location = new Point(100, currentBtnDerecha.Location.Y);
                leftBorderBtnDerecha.Visible = true;
                leftBorderBtnDerecha.BringToFront();


            }
        }
        private void DisableButtonDerecha()
        {
            if (currentBtnDerecha != null)
            {
                currentBtnDerecha.BackColor = Color.RoyalBlue;
                currentBtnDerecha.ForeColor = Color.Gainsboro;
                currentBtnDerecha.TextAlign = ContentAlignment.MiddleCenter;
                //currentBtn.IconColor = Color.Gainsboro;
                currentBtnDerecha.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtnDerecha.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ActivateButton(sender);
            Producto miProducto;
            Formcargar modalCargar = new Formcargar();


            if (modalCargar.ShowDialog() == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(modalCargar.tbProducto.Text) || string.IsNullOrWhiteSpace(modalCargar.tbCantidad.Text) || string.IsNullOrWhiteSpace(modalCargar.tbDescripcion.Text))
                {
                    MessageBox.Show("Debe completar todos los campos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string nombre = modalCargar.tbProducto.Text;
                    double kg = Convert.ToDouble(modalCargar.tbCantidad.Text);
                    string descripcion = modalCargar.tbDescripcion.Text;
                    DateTime fecha = DateTime.Now;
                    miProducto = new Producto(fecha, nombre, descripcion, kg);

                    miSistema.AgregarProducto(miProducto, kg, descripcion);
                }
            }
            Actualizarformulario();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            int indice = 0;
            Producto producto;
            double kginicial = 0;
            string descripcion = "";

            if (miModalModificar.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrWhiteSpace(miModalModificar.tbDescripModif.Text) || string.IsNullOrWhiteSpace(miModalModificar.tbKgInicialModif.Text) || miModalModificar.cbModificar.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe completar todos los campos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    indice = miModalModificar.cbModificar.SelectedIndex;
                    producto = miSistema.Productos[indice];
                    kginicial = Convert.ToDouble(miModalModificar.tbKgInicialModif.Text);
                    descripcion = miModalModificar.tbDescripModif.Text;
                    DialogResult result = MessageBox.Show("Esta seguro que desea modificar el producto " + producto.Nombre + "?" + "\nKg Inicial: " + kginicial + "\nDescripcion: " + descripcion, "Confirmar Datos", MessageBoxButtons.OKCancel);

                    miSistema.ModificarProducto(producto, kginicial, descripcion);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            int indice = 0;

            if (miModalEliminar.ShowDialog() == DialogResult.OK)
            {
                if (miModalEliminar.cbEliminar.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un producto.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    indice = miModalEliminar.cbEliminar.SelectedIndex;
                    Producto producto = miSistema.Productos[indice];
                    DialogResult result = MessageBox.Show("Esta seguro que desea eliminar el producto " + producto.Nombre + "?", "Confirmar Datos", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        miSistema.EliminarProducto(indice);
                        Actualizarformulario();
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ActivateButtonDerecha(sender);
            modalporcentaje modalPorcentaje = new modalporcentaje();
            modalPorcentaje.ShowDialog();
        }

        private void btnGenerarExcel_Click(object sender, EventArgs e)
        {
            ActivateButtonDerecha(sender);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo CSV|*.csv";
            saveFileDialog.Title = "Historial de Ventas";
            saveFileDialog.FileName = "HistorialDeVentas.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = saveFileDialog.FileName;
                miSistema.GenerarCSV(miSistema.Productos, rutaArchivo);
            }
        }





        private bool EsDecimalValido(string texto)
        {
            return decimal.TryParse(texto, out _);
        }

        private bool isValidating = false;
        private void ValidarFormatoTextBoxDecimal(object sender, EventArgs e)
        {
            if (isValidating) return;
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                string texto = textBox.Text.Trim(); // Eliminar espacios en blanco al principio y al final

                if (!string.IsNullOrEmpty(texto) && !EsDecimalValido(texto))
                {
                    isValidating = true;
                    MessageBox.Show("Formato incorrecto,Ingrese numeros por favor, en caso de ser una cifra decimal ingresar el valor separado por " + " ' , ' (coma).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Clear(); // Limpia el TextBox para que el usuario pueda volver a ingresar el valor.
                    isValidating = false;
                }
            }
        }

        private bool EsStringMinusculaValido(string texto)
        {
            // Verifica si el texto está en minúsculas
            return !string.IsNullOrEmpty(texto) && texto.All(char.IsLetter) && texto == texto.ToLower();
        }
        private void ValidarFormatoTextBoxString(object sender, EventArgs e)
        {
            if (isValidating) return;
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                string texto = textBox.Text.Trim();
                if (!string.IsNullOrEmpty(texto) && !EsStringMinusculaValido(texto))
                {
                    isValidating = true;
                    MessageBox.Show("Formato incorrecto, ingrese un Texto por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Clear(); // Limpia el TextBox para que el usuario pueda volver a ingresar el valor.
                    isValidating = false;
                }
            }
        }

        private void cbSeleccionProducto2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            modalAcercaDe miModal= new modalAcercaDe();
            miModal.ShowDialog();
        }
    }
}
