using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ControlDeStock.net8
{
    
    internal class Sistema
    {
        private List<Producto> productos = new List<Producto>();
        public List<Producto> Productos { get { return productos; } }

        public void AgregarProducto(Producto productoadd,double kgini,string descripcion)
        {

            bool existe = false;
            foreach (Producto p in productos)
            {
                if (p.Nombre == productoadd.Nombre)
                {
                    existe = true;
                    p.VentasKg += productoadd.VentasKg;
                    p.ModificarMismoObjeto(kgini,descripcion);
                    break;

                }

            }
            if (!existe)
            {
                productos.Add(productoadd);
            }
        }

        public void EliminarProducto (int indice)
        {
            productos.RemoveAt(indice);
        }

        public void ModificarProducto(Producto producto, double kgini, string descripcion)
        {
            producto.ActualizarProducto(kgini, descripcion);
        }

        public void GenerarCSV(List<Producto> producto, string rutaArchivo)
        {
            if (File.Exists(rutaArchivo))
                File.Delete(rutaArchivo);

            FileStream fs = new FileStream(rutaArchivo, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine($"Fecha y Hora;Producto;Stock inicial en kg; Stock actual ;Recaudacion");

            foreach (Producto product in producto)
            {
                sw.WriteLine($"{product.Fecha};{product.Nombre};{product.Stock};{product.VentasKg};{product.Ganancias}");
            }

            sw.Close();
            fs.Close();
        }
    }
}
