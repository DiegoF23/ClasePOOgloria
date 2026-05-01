using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStockVentas
{
    // HERENCIA:
    // Televisor hereda de Producto
    public class Televisor : Producto
    {
        public int Pulgadas { get; set; }
        public string TipoPantalla { get; set; }

        public Televisor(
            int codigo,
            string nombre,
            decimal precio,
            int stock,
            int pulgadas,
            string tipoPantalla)
            : base(codigo,nombre,precio,stock)
        {
            Pulgadas = pulgadas;
            TipoPantalla = tipoPantalla;
        }

        // POLIMORFISMO:
        public override decimal CalcularPrecioFinal()
        {
            return Precio * 1.10m; // Televisores tienen un 10% de recargo
        }

            public override void MostrarInformacion()
            {
                Console.WriteLine("=== Televisor ===");
            base.MostrarInformacion();
                Console.WriteLine("Pulgadas: " + Pulgadas);
                Console.WriteLine("Tipo de pantalla: " + TipoPantalla);
                Console.WriteLine("Precio final: $" + CalcularPrecioFinal());
        }
    }
}
