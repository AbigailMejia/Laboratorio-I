using LaboratorioSistema;
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
            Console.WriteLine("Bienvenido al Sistema de Ventas de la empresa Los Patos");
            Console.WriteLine("A que area desea dirigirse?\n\n1.Usuarios\n2.Inventario\n3.Factutas");
            int respuesta = int.Parse(Console.ReadLine());
            
            char op = 'n';
            while (op != 's')
            {
                if (respuesta == 1)
                {
                    us.Principal();
                }
                if (respuesta == 2)
                {

                }
                if (respuesta == 1)
                {

                }
            }
        }
    }
}
