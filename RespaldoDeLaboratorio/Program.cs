﻿using LaboratorioSistema;
using System;


namespace RespaldoDeLaboratorio
{
    class Program
    {
        static void Main(string[] args)

        {
            Usuarios us = new Usuarios();
            Inventarios inv = new Inventarios();
            Factura fac = new Factura();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("|                                                         |");
            Console.WriteLine("| Bienvenido al Sistema de Ventas de la empresa Los Patos |");
            Console.WriteLine("|                                                         |");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            char op = 'n';
            while (op != 's')
            {
                us.Principal();
                

                Console.WriteLine("Desea salir [s/n]");
                op = char.Parse(Console.ReadLine());
            }
        }
    }
}
