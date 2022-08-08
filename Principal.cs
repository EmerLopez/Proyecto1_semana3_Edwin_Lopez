using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_semana_3
{
    class Principal
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Programa Principal");
            System.Console.WriteLine("Primer Programa");

            System.Console.ReadKey();

            int repetir;


            menu_interno();


            System.Console.WriteLine("Ingrese la opcion: ");
            repetir = Int32.Parse(Console.ReadLine());


            while (repetir == 1)
            {
                menu_interno();



            }
        }
        static void menu_interno()
        {

        }
        static void programa_if()
        {
            System.Console.WriteLine("Aqui llamo el ejemplo if");
        }
        static void programa_switch()
        {
            System.Console.WriteLine("Aqui llamo el ejemplo switch");
        }
        static void programa_for()
        {
            System.Console.WriteLine("Aqui llamo el ejemplo for");
        }
        static void programa_while()
        {
            System.Console.WriteLine("Aqui llamo el ejemplo while");
        }
        static void programa_dowhile()
        {
            System.Console.WriteLine("Aqui llamo el ejemplo dowhile");
        }
    }
    
}
