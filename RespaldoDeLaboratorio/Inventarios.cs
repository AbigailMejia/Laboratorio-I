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
        public void ingreso()
        {
            escribir = File.AppendText(ruta);
            Console.WriteLine("Ingrese datos del inventario");
            Console.WriteLine("Inngrese nombre del producto");
            string producto = Console.ReadLine();
            escribir.WriteLine(""+producto);
            Console.WriteLine("Inngrese el precio del producto");
            string precio = Console.ReadLine();
            escribir.WriteLine(precio);
            Console.WriteLine("Inngrese la cantidad  del producto");
            string cantidad = Console.ReadLine();
            escribir.WriteLine(cantidad);
            escribir.Close();
        }
         static string buscar(string nombre)
        {
            string linea = "Contacto no encontrado";
            leer = File.OpenText(ruta);
            linea = leer.ReadToEnd();
            return linea;
        }
        static void invenmenuprin()
        {
            Console.WriteLine("Bienvenido al area de inventario\nQue desea hacer?\n1.Cargar Inventario\n2.Mostrar Inventario");
            int prin = int.Parse(Console.ReadLine());
            if (prin == 1)
            {
                Console.WriteLine("Ingrese contrasena");
                int contra = int.Parse(Console.ReadLine());
                if (contra == 456)
                {

                }
                else
                {
                    Console.WriteLine("Usted no esta autorizado para ingresar a esta area");
                }
            }
            else if (prin == 2)
            {
                Console.WriteLine("Ingrese contrasena");
                int contra = int.Parse(Console.ReadLine());
                if (contra == 456)
                {

                }
                else
                {
                    Console.WriteLine("Usted no esta autorizado para ingresar a esta area");
                }
            }

        }


    }
}

