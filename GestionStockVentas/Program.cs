using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStockVentas
{
    class Program
    {
        static void Main(string[] args)
        {
            Sucursal sucursalCentro = new Sucursal("Centro");
            Sucursal sucursalNorte = new Sucursal("Norte");

            sucursalCentro.AgregarProducto(
                new Televisor(101, "Samsung 50", 250000, 5, 50, "LED")
            );

            sucursalNorte.AgregarProducto(
                new Televisor(201, "Samsung 50", 250000, 2, 50, "LED")
            );

            sucursalCentro.MostrarProductos();
            sucursalNorte.MostrarProductos();

            Console.ReadKey();
        }
    }
}
