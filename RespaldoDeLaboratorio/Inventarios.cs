using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LaboratorioSistema
{
    class Inventarios
    {
        Factura fac = new Factura();
        static string ruta = "inventario.txt";
        static StreamWriter escribir;
        static StreamReader leer;
        public void mostrarinv()
        {
            Console.WriteLine(mostrarInventario(llenar("ENTER")));
        }
        public void ingreso()
        {
            escribir = File.AppendText(ruta);
            Console.WriteLine("Ingrese datos del inventario");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("");
            escribir.WriteLine("-------------------------------------------------------");
            escribir.WriteLine("");
            Console.WriteLine("Ingrese fecha");
            string fecha = Console.ReadLine();
            escribir.WriteLine("Fecha: "+fecha);
            Console.WriteLine("Ingrese nombre del producto");
            string producto = Console.ReadLine();
            escribir.WriteLine("Producto: "+producto);
            Console.WriteLine("Ingrese el precio del producto");
            string precio = Console.ReadLine();
            escribir.WriteLine("Precio: "+precio);
            Console.WriteLine("Ingrese la cantidad  del producto");
            int cantidad = int.Parse(Console.ReadLine());
            escribir.WriteLine("Cantidad: "+cantidad);
            escribir.Close();
        }
         static string mostrarInventario(string nombre)
        {
            string linea = "Inventario no encontrado";
            leer = File.OpenText(ruta);
            linea = leer.ReadToEnd();
            return linea;
        }
        static string llenar(string dato)
        {
            Console.WriteLine("ingrese " + dato + ":");
            return (Console.ReadLine());
        }
                
    }
}

