using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace LaboratorioSistema
{
    class Usuarios
    {
        static string ruta = "Usuarios.txt";
        static FileStream archivo;
        static StreamReader leer;
        static StreamWriter escribir;
        public void Principal()
        {

            Console.WriteLine("es administrador o trabajador [a/t]");
            char user = char.Parse(Console.ReadLine());
            if(user=='a')
            {
                Console.WriteLine("Ingrese la contrasena");
                int contra = int.Parse(Console.ReadLine());
                if(contra==123)
                {
                    Console.WriteLine("Que desea hacer?\n1.Crear usuario\n2.Mostrar Inventario\n3.Mostrar Usuarios\n4. Mostrar Facturas");
                    int admin = int.Parse(Console.ReadLine());
                    if(admin==1)
                    {
                            guardar(llenar("nombre"), llenar("contrasena"));
                       
                    }
                    if(admin==2)
                    {

                    }
                    if (admin == 3)
                    {
                        Console.WriteLine(buscar(llenar("ingrese nombre a buscar")));
                    }
                    if (admin == 4)
                    {

                    }
                }
            }
            
        }
        static void guardar(string nombre, string contrasena)
        {
            escribir = File.AppendText(ruta);
            escribir.WriteLine(nombre + " " + contrasena );
            escribir.Close();
        }
        static string llenar(string dato)
        {
            Console.WriteLine("ingrese " + dato + ":");
            return (Console.ReadLine());
        }
        static string buscar(string nombre)
        {
            string linea = "Contacto no encontrado";
            leer = File.OpenText(ruta);
            linea = leer.ReadToEnd();
            return linea;
        }
    }
}
