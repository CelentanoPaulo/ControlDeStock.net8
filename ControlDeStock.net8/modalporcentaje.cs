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
            if (string.IsNullOrWhiteSpace(tbValorProducto.Text) || string.IsNullOrWhiteSpace(tbPorcentaje.Text))
            {
                MessageBox.Show("Debe completar todos los campos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double valor1 = Convert.ToDouble(tbValorProducto.Text);
                double valor2 = Convert.ToDouble(tbPorcentaje.Text);
                double ganancia = valor1 * (valor2 / 100);
                double resultado = valor1 + ganancia;
                tbResultado.Text = resultado.ToString();
            }
        }

        private void tbValorProducto_TextChanged(object sender, EventArgs e)
        {
            ValidarFormatoTextBoxDecimal(sender, e);
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

        private void tbPorcentaje_TextChanged(object sender, EventArgs e)
        {
            ValidarFormatoTextBoxDecimal(sender,e);
        }
    }
}
