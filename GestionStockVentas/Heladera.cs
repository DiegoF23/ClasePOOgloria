using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStockVentas
{
    public class Heladera : Producto
    {
        public int CapacidadLitros { get; set; }
        public string Tipo { get; set; }

        public Heladera(
            int codigo,
            string nombre,
            decimal precio,
            int stock,
            int capacidadLitros,
            string tipo
        ) : base(codigo, nombre, precio, stock)
        {
            CapacidadLitros = capacidadLitros;
            Tipo = tipo;
        }

        // POLIMORFISMO:
        // Heladera calcula el precio final con otro recargo.
        public override decimal CalcularPrecioFinal()
        {
            return Precio * 1.15m;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("=== Heladera ===");
            base.MostrarInformacion();
            Console.WriteLine("Capacidad: " + CapacidadLitros + " litros");
            Console.WriteLine("Tipo: " + Tipo);
            Console.WriteLine("Precio final: $" + CalcularPrecioFinal());
        }
    }
}
