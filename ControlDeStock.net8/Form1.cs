using System.Text.Json;
using Newtonsoft.Json;

namespace ControlDeStock.net8
{
    public partial class Form1 : Form
    {
        Sistema miSistema;
        public Form1()
        {
            InitializeComponent();
        }


        public void Actualizarformulario()
        {
            cbSeleccionProducto1.Items.Clear();
            cbSeleccionProducto2.Items.Clear();
            foreach (Producto p in miSistema.Productos)
            {
                cbSeleccionProducto1.Items.Add(p.Nombre);
                cbSeleccionProducto2.Items.Add(p.Nombre);


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

        private void cargarNuevoProductoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Producto miProducto;
            Formcargar modalCargar = new Formcargar();

            if (modalCargar.ShowDialog() == DialogResult.Yes)
            {
                string nombre = modalCargar.tbProducto.Text;
                double kg = Convert.ToDouble(modalCargar.tbCantidad.Text);
                string descripcion = modalCargar.tbDescripcion.Text;
                DateTime fecha = DateTime.Now;
                miProducto = new Producto(fecha, nombre, descripcion, kg);
                miSistema.AgregarProducto(miProducto);

            }
            Actualizarformulario();
        }

        private void btnCargarVenta_Click_1(object sender, EventArgs e)
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
                tbIngresarPrecio.Clear();
                tbVentasKg.Clear();
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
                

        }

      
        private void Form1_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            string objJson = JsonConvert.SerializeObject(miSistema);
            File.WriteAllText("data.json", objJson);
            
        }
    }
}
