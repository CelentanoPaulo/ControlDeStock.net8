using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeStock.net8
{
    internal class Producto
    {
        private DateTime fecha;
        private string nombre;
        private double inicialkg;
        private double ventaskg ;
        private string descripcion;
        private decimal ganancias ;
        private double stock;
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public double inicialKg { get { return inicialkg; } set { inicialkg = value; } }
        public double VentasKg { get { return ventaskg; } set { ventaskg = value; } }
        public decimal Ganancias { get { return ganancias; } set { ganancias = value; } }
        public double Stock { get { return stock; } set { stock = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }

       
       
        public Producto(DateTime fecha, string nombre, string descripcion, double kg)
        {
            
            this.fecha = fecha;
            this.nombre = nombre;
            inicialkg = kg;
            stock = kg;
            this.descripcion = descripcion;
            ventaskg = 0;
        }

        public void GenerarVenta(double kilos)
        {
            VentasKg += kilos;
            Stock -= kilos;
        }

        public string ReturnDetalle()
        {
            // muestra las ganancias con separador de miles.
            string stockFormateado = stock.ToString("F2"); // redondea y muestra 'stock' con 2 decimales.
            string ventasKgFormateado = ventaskg.ToString("F2"); // redondea y muestra 'ventaskg' con 2 decimales. 
            string resultado = ganancias.ToString("N"); //muestra las gananacias con separador de miles.
            return "Fecha de carga: " + fecha + Environment.NewLine + "Producto: " + nombre + Environment.NewLine + "Stock Inicial: " + inicialKg + " kg" + Environment.NewLine + "Cantidad en Stock: " + stockFormateado + " kg" + Environment.NewLine +
            "Cantidad vendida: " + ventaskg + " kg." + Environment.NewLine + "Monto Vendido: $" + resultado + Environment.NewLine +
            "Descripcion: " + descripcion;

        }

        public void AcumularGanancias(decimal ganancias)
        {
            this.ganancias += ganancias;
        }

        public void ModificarMismoObjeto(double kginicial,string descripcion)
        {
            this.descripcion = descripcion;
            inicialKg += kginicial;
            stock += kginicial;
        }

        public void ActualizarProducto(double kginicial, string descripcion)
        {
            this.descripcion = descripcion;
            inicialKg = kginicial;
            stock = kginicial;
        }
    }
}
