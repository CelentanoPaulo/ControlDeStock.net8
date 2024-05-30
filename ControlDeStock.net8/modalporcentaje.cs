using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeStock.net8
{
    public partial class modalporcentaje : Form
    {
        public modalporcentaje()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valor1= Convert.ToDouble(tbValorProducto.Text);
            double valor2= Convert.ToDouble(tbPorcentaje.Text);
            double ganancia = valor1 * (valor2 / 100);
            double resultado = valor1 + ganancia;
            tbResultado.Text = resultado.ToString();
        }
    }
}
