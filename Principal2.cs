using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Proyecto1_semana_3.Ejemplo_if;
using static Proyecto1_semana_3.Ejemplo_switch;
using static Proyecto1_semana_3.Ejemplo_For;
using static Proyecto1_semana_3.Ejemplo_DoWhile;
using static Proyecto1_semana_3.Ejemplo_While;
namespace Proyecto1_semana_3
{
    class Principal2
    {
        
        static void Main(string[] args)
        {
            System.Console.WriteLine("Programa Principal");
            System.Console.WriteLine("Primer Programa");

            System.Console.ReadKey();
            int repetir;
           
            //menu_interno();

            //System.Console.WriteLine("Ingrese la opcion: ");
            //repetir = Int32.Parse(Console.ReadLine());


            // (repetir == 1)
            do
            {
                Console.Clear();
                menu_interno();
                Console.Clear();
                System.Console.WriteLine("Ingrese 1 para repetir menú");
                System.Console.WriteLine("Ingrese 2 para salir ");
                repetir = Int32.Parse(Console.ReadLine());

            } while (repetir == 1) ;


        }
        static void menu_interno()
        {
            string opcion;
            int opcionint;

            System.Console.WriteLine("Menu Principal");
            System.Console.WriteLine("1.Ejemplo If");
            System.Console.WriteLine("2.Ejemplo Switch");
            System.Console.WriteLine("3.Ejemplo For");
            System.Console.WriteLine("4.Ejemplo Wor");
            System.Console.WriteLine("5.Ejemplo Do While");
            System.Console.WriteLine("Selecciona tu opcion: ");
            opcion = Console.ReadLine();
            opcionint = Int32.Parse(opcion);


            switch (opcionint)
            {
                case 1:

                    estructura_if();

                    break;

                case 2:

                    estructura_switch();
                    break;

                case 3:

                    estructura_for();
                    break;

                case 4:

                    estructura_While();
                    break;
                case 5:

                    estructura_Dowhile();
                    break;

                default:
                    System.Console.WriteLine("opcion no valida");
                    break;

            }

            System.Console.ReadKey();

            
            //Console.Clear();
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
