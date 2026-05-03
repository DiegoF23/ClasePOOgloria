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

            sucursalCentro.AgregarProducto(new Televisor(101, "Samsung 50", 250000, 5, 50, "LED"));
            sucursalCentro.AgregarProducto(new Heladera(102, "Whirlpool No Frost", 400000, 3, 350, "No Frost"));

            sucursalNorte.AgregarProducto(new Lavarropas(201, "Drean 8kg", 300000, 4, 8, "Automático"));
            sucursalNorte.AgregarProducto(new Televisor(202, "LG 43", 220000, 6, 43, "Smart LED"));

            Sucursal sucursalSeleccionada = SeleccionarSucursal(sucursalCentro, sucursalNorte);

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine();
                Console.WriteLine("***************************************");
                Console.WriteLine("Sucursal seleccionada: " + sucursalSeleccionada.Nombre);
                Console.WriteLine("Seleccione accion:");
                Console.WriteLine("1 - Agregar producto");
                Console.WriteLine("2 - Listar productos");
                Console.WriteLine("3 - Vender producto");
                Console.WriteLine("4 - Cambiar sucursal");
                Console.WriteLine("0 - Salir");
                Console.WriteLine("***************************************");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarProductoDesdeMenu(sucursalSeleccionada);
                        break;

                    case "2":
                        sucursalSeleccionada.MostrarProductos();
                        break;

                    case "3":
                        VenderDesdeMenu(sucursalSeleccionada);
                        break;
                    case "4":
                        sucursalSeleccionada = SeleccionarSucursal(sucursalCentro, sucursalNorte);
                        break;

                    case "0":
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
                
            }


            Console.WriteLine("Programa finalizado");
            Console.ReadKey();


        }
        static Sucursal SeleccionarSucursal(Sucursal centro, Sucursal norte)
        {
            Console.WriteLine("Seleccione sucursal:");
            Console.WriteLine("1 - Centro");
            Console.WriteLine("2 - Norte");

            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                return centro;
            }
            else if (opcion == "2")
            {
                return norte;
            }
            else
            {
                Console.WriteLine("Opción inválida. Se selecciona Centro por defecto.");
                return centro;
            }
        }

        static void VenderDesdeMenu(Sucursal sucursal)
        {
            Console.WriteLine("Ingrese código de producto:");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Cantidad a vender:");
            int cantidad = int.Parse(Console.ReadLine());

            sucursal.VenderProducto(codigo, cantidad);
        }

        static void AgregarProductoDesdeMenu(Sucursal sucursal)
        {
            Console.WriteLine();
            Console.WriteLine("***************************************");
            Console.WriteLine("Tipo de producto:");
            Console.WriteLine("1 - Televisor");
            Console.WriteLine("2 - Heladera");
            Console.WriteLine("3 - Lavarropas");
            Console.WriteLine("***************************************");
            string tipo = Console.ReadLine();

            Console.WriteLine("Código:");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Nombre:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Precio:");
            decimal precio = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Stock:");
            int stock = int.Parse(Console.ReadLine());

            if (tipo == "1")
            {
                Console.WriteLine("Pulgadas:");
                int pulgadas = int.Parse(Console.ReadLine());

                Console.WriteLine("Tipo de pantalla:");
                string tipoPantalla = Console.ReadLine();

                Televisor televisor = new Televisor(codigo, nombre, precio, stock, pulgadas, tipoPantalla);
                sucursal.AgregarProducto(televisor);
            }
            else if (tipo == "2")
            {
                Console.WriteLine("Capacidad en litros:");
                int capacidad = int.Parse(Console.ReadLine());

                Console.WriteLine("Tipo:");
                string tipoHeladera = Console.ReadLine();

                Heladera heladera = new Heladera(codigo, nombre, precio, stock, capacidad, tipoHeladera);
                sucursal.AgregarProducto(heladera);
            }
            else if (tipo == "3")
            {
                Console.WriteLine("Carga en kg:");
                int carga = int.Parse(Console.ReadLine());

                Console.WriteLine("Tipo:");
                string tipoLavarropas = Console.ReadLine();

                Lavarropas lavarropas = new Lavarropas(codigo, nombre, precio, stock, carga, tipoLavarropas);
                sucursal.AgregarProducto(lavarropas);
            }
            else
            {
                Console.WriteLine("Tipo inválido.");
                return;
            }

            Console.WriteLine("Producto agregado correctamente.");
        }

    }
}
