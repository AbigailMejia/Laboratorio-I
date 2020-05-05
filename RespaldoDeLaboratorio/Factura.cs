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

        static void facturacion()
        {
            escribir = File.AppendText(ruta);
             escribir.WriteLine("               LOS PATOS S.A.");
            escribir.WriteLine("         ALMACEN LOS PATOS NO. 156");
            escribir.WriteLine("       C.C PRADERA CONCEPCION KM 15.5");
            escribir.WriteLine("CARRETERA A EL SALVADOR, SANTA CATARIANA PINULA");
            escribir.WriteLine("");
            escribir.WriteLine("                   FACTURA");
            escribir.WriteLine("           SERIE V78 DE 1 A 10000000");
            escribir.WriteLine("");
            escribir.WriteLine("");
            escribir.Close();
            personal(llenar("nombre"), llenar("apellido"), llenar("direccion"), llenar("nit"));
        }
        static string llenar(string dato)
        {
            Console.WriteLine("ingrese " + dato + ": ");
            return (Console.ReadLine());
        }
        static void personal(string nombre, string apellido, string direccion, string nit)
        {
            escribir = File.AppendText(ruta);
            escribir.WriteLine("NOMBRE: " + nombre + "  APELLIDO: " + apellido + "  DIRECCION: " + direccion + "  NIT: " + nit);
            escribir.Close();
        }

    }
}
