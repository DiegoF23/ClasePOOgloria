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
        public Producto BuscarProductoPorCodigo(int codigo)
        {
                foreach (Producto producto in Productos)
                {
                    if (producto.Codigo == codigo)
                    {
                        return producto;
                    }
                }
            return null; 
        }

        public decimal VenderProducto(int codigo, int cantidad)
        {
            Producto producto = BuscarProductoPorCodigo(codigo);

            if (producto == null)
            {
                Console.WriteLine("Producto no encontrado.");
                return 0;
            }

            bool ventaCorrecta = producto.DescontarStock(cantidad);

            if (ventaCorrecta == false)
            {
                Console.WriteLine("Stock insuficiente o cantidad inválida.");
                return 0;
            }

            decimal total = producto.CalcularPrecioFinal() * cantidad;

            Console.WriteLine("***************************************");
            Console.WriteLine("Venta realizada con éxito.");
            Console.WriteLine("Total: $" + total);
            Console.WriteLine("Stock restante: " + producto.Stock);
            Console.WriteLine("***************************************");

            return total;
        }

    }
}
