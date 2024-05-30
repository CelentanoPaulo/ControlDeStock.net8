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
    public partial class modalModificar : Form
    {
        public modalModificar()
        {
            InitializeComponent();
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
        private void tbKgInicialModif_TextChanged(object sender, EventArgs e)
        {
            ValidarFormatoTextBoxDecimal(sender,e);
        }
    }
}
