using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStockVentas
{
    public class Sucursal
    {
        public string Nombre { get; set; }

        // COMPOSICIÓN:
        // Una sucursal tiene una lista de productos.
        public List<Producto> Productos { get; private set; }

        public Sucursal(string nombre)
        {
            Nombre = nombre;
            Productos = new List<Producto>();
        }

        public void AgregarProducto(Producto producto)
        {
            Productos.Add(producto);
        }

        public void MostrarProductos()
        {
            Console.WriteLine("Productos de la sucursal: " + Nombre);
            Console.WriteLine("--------------------------------");

            if (Productos.Count == 0)
            {
                Console.WriteLine("No hay productos cargados.");
                return;
            }

            foreach (Producto producto in Productos)
            {
                producto.MostrarInformacion();
                Console.WriteLine("--------------------------------");
            }
        }
    }
}
