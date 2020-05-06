using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace LaboratorioSistema
{
    class Usuarios
    {
        Inventarios inv = new Inventarios();
        Factura fac = new Factura();
        static string ruta = "Usuarios.txt";
        static StreamReader leer;
        static StreamWriter escribir;
        
        public void Principal()
        {

            Console.WriteLine("Es administrador o trabajador [a/t]");
            char user = char.Parse(Console.ReadLine());
            if(user=='a')
            {

                Console.WriteLine("Ingrese la contrasena");
                int contra = int.Parse(Console.ReadLine());
                if(contra==123)
                {
                    Console.WriteLine("Que desea hacer?\n1.Crear usuario\n2.Mostrar Inventario\n3.Mostrar Usuarios\n4.Mostrar Facturas");
                    int admin = int.Parse(Console.ReadLine());
                    if(admin==1)
                    {
                            crear(llenar("nombre"), llenar("contrasena"),llenar("cargo"));
                       
                    }
                    if(admin==2)
                    {
                        inv.mostrarinv();
                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine("");
                    }
                    if (admin == 3)
                    {
                        Console.WriteLine(mostrarUsuario(llenar("ingrese ENTER")));
                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine("");

                    }
                    if (admin == 4)
                    {
                        fac.mostrarfac();
                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine("");
                    }
                }
                else 
                {
                    Console.WriteLine("");
                    Console.WriteLine("Usted no esta autorizado para ingresar a esta area!!");
                }
            }
            else if(user=='t')
            {
                Console.WriteLine("Ingrese la contrasena");
                int contra = int.Parse(Console.ReadLine());
                if (contra == 456)
                {
                    Console.WriteLine("Que desea hacer?\n1.cargar inventario\n2.Facturar producto");
                    int admin = int.Parse(Console.ReadLine());
                    if (admin == 1)
                    {
                        inv.ingreso();
                    }
                    else if (admin == 2)
                    {
                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine("");
                        inv.mostrarinv();
                        fac.facturacion();
                    }

                }
                else
                {
                    Console.WriteLine("Usted no esta autorizado para ingresar a esta area");
                }
            }
            
        }
                
        static void crear(string nombre, string contrasena,string cargo)
        {
            escribir = File.AppendText(ruta);
            escribir.WriteLine(nombre + " " + contrasena+" "+ cargo );
            escribir.Close();
        }
        static string llenar(string dato)
        {
            Console.WriteLine("ingrese " + dato + ":");
            return (Console.ReadLine());
        }
        static string mostrarUsuario(string nombre)
        {
            string linea = "Usuario no encontrado";
            leer = File.OpenText(ruta);
            linea = leer.ReadToEnd();
            return linea;
        }

    }
}
