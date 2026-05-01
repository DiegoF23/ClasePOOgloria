using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStockVentas
{
    // ABSTRACCIÓN:
    // Producto representa lo común a todos los productos.
    // No se instancia directamente porque es una idea general.
    public abstract class Producto
    {
        // ENCAPSULAMIENTO:
        // Usamos propiedades para acceder a los datos de manera ordenada.
        public int Codigo { get; protected set; }
        public string Nombre { get; protected set; }
        public decimal Precio { get; protected set; }
        public int Stock { get; protected set; }

        public Producto(int codigo, string nombre, decimal precio, int stock)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }

        // POLIMORFISMO:
        // Cada producto concreto calculará su precio final de forma diferente.
        public abstract decimal CalcularPrecioFinal();

        public virtual void MostrarInformacion()
        {
            Console.WriteLine("Código: " + Codigo);
            Console.WriteLine("Producto: " + Nombre);
            Console.WriteLine("Precio base: $" + Precio);
            Console.WriteLine("Stock: " + Stock);
        }


    }
}
