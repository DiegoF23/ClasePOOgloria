using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStockVentas
{
    public class Lavarropas : Producto
    {
        public int CargaKg { get; set; }
        public string Tipo { get; set; }

        public Lavarropas(
            int codigo,
            string nombre,
            decimal precio,
            int stock,
            int cargaKg,
            string tipo
        ) : base(codigo, nombre, precio, stock)
        {
            CargaKg = cargaKg;
            Tipo = tipo;
        }

        // POLIMORFISMO:
        // Lavarropas tiene su propia forma de calcular precio final.
        public override decimal CalcularPrecioFinal()
        {
            return Precio * 1.08m;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("=== Lavarropas ===");
            base.MostrarInformacion();
            Console.WriteLine("Carga: " + CargaKg + " kg");
            Console.WriteLine("Tipo: " + Tipo);
            Console.WriteLine("Precio final: $" + CalcularPrecioFinal());
        }
    }
}
