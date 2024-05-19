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

        public void AgregarProducto(Producto productoadd)
        {
            bool existe = false;
            foreach (Producto p in productos)
            {
                if (p.Nombre == productoadd.Nombre)
                {
                    existe = true;
                    p.Kg += productoadd.Kg;
                    p.ModificarMismoObjeto(p.inicialKg);
                    break;

                }

            }
            if (!existe)
            {
                productos.Add(productoadd);
            }
        }
    }
}
