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
    public partial class Formcargar : Form
    {
        public Formcargar()
        {
            InitializeComponent();
        }
        private bool isValidating = false;
        private bool EsStringMinusculaValido(string texto)
        {
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
        private void tbProducto_TextChanged(object sender, EventArgs e)
        {
            ValidarFormatoTextBoxString(sender, e);
        }


        private bool EsDecimalValido(string texto)
        {
            return decimal.TryParse(texto, out _);
        }


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
        private void tbCantidad_TextChanged(object sender, EventArgs e)
        {
            ValidarFormatoTextBoxDecimal(sender, e);
        }
    }
}
