using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LaboratorioSistema
{
    class Factura
    {
        static string ruta = "factura.txt";
        static StreamWriter escribir;
        static StreamReader leer;

    
        public void facturacion()
        {
            escribir = File.AppendText(ruta);
            escribir.WriteLine("--------------------------------------------------");
            escribir.WriteLine("");
            escribir.WriteLine("               LOS PATOS S.A.");
            escribir.WriteLine("         ALMACEN LOS PATOS NO. 156");
            escribir.WriteLine("       C.C PRADERA CONCEPCION KM 15.5");
            escribir.WriteLine("CARRETERA A EL SALVADOR, SANTA CATARIANA PINULA");
            escribir.WriteLine("                 NIT:1234567-8");
            escribir.WriteLine("");
            escribir.WriteLine("        DOCUMENTO TRIBUTARIO ELECTRONICO"); 
            escribir.WriteLine("                   FACTURA");
            escribir.WriteLine("           SERIE V78 DE 1 A 10000000");
            escribir.WriteLine("               NUMERO: 15302221");
            escribir.WriteLine("");
            escribir.WriteLine("");
            escribir.WriteLine("");
            escribir.WriteLine("");
            escribir.Close();
            personal(llenar("Nombre del comprador"), llenar("apellido"), llenar("direccion"), llenar("nit"));
            char op = 's';
            while (op != 'n')
            {
                productos(llenar("Nombre del producto"));
                sub();
                Console.WriteLine("Otro  producto [s/n]: ");
                op = char.Parse(Console.ReadLine());
            }


        }
        static string llenar(string dato)
        {
            Console.WriteLine("ingrese " + dato + ": ");
            return (Console.ReadLine());
        }
        static void personal(string nombre, string apellido, string direccion, string nit)
        {
            escribir = File.AppendText(ruta);
            escribir.WriteLine("NOMBRE: " + nombre);
            escribir.WriteLine("APELLIDO: " + apellido);
            escribir.WriteLine("DIRECCION: " + direccion);
            escribir.WriteLine("NIT: " + nit);
            escribir.Close();
        }
        static void productos(string NombreProducto)
        {
            escribir = File.AppendText(ruta);
            escribir.WriteLine("");
            escribir.WriteLine("Nombre del Producto:  " + NombreProducto);
            escribir.Close();
        }
        static void sub()
        {
            double precio = 0;
            double cant = 0;
            Console.WriteLine("precio");
            precio = double.Parse(Console.ReadLine());
            Console.WriteLine("cantidad");
            cant = double.Parse(Console.ReadLine());
            escribir = File.AppendText(ruta);
            escribir.WriteLine("");
            escribir.WriteLine("Precio:  " + precio + "  " + "Cantidad:  " + cant);
            double SubTotal = precio * cant;
            double total = 0;
            total = total + SubTotal;
            escribir.WriteLine("Total a pagar:  " + total);
            escribir.WriteLine("");
            escribir.WriteLine("");
            escribir.WriteLine("                 GRACIAS POR TU COMPRA");
            escribir.WriteLine("              SUJETO A PAGOS TRIMESTRALES");
            escribir.WriteLine("                            ...");
            escribir.WriteLine(        "UN PLACER SERVIRLE, ESPERAMOS QUE VUELVA!");
            escribir.WriteLine("                    LOS PATOS S.A.");
            escribir.WriteLine("");
            escribir.Close();

        }
        public void mostrarfac()
        {
            Console.WriteLine(mostrarFactura(llenar("ENTER")));
        }
        static string mostrarFactura(string nombre)
        {
            string linea = "Factura no encontrado";
            leer = File.OpenText(ruta);
            linea = leer.ReadToEnd();
            return linea;
        }
    }
}
