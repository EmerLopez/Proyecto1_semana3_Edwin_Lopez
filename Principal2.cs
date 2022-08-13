using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Proyecto1_semana3_Edwin_Lopez.Ejemplo_if;
using static Proyecto1_semana3_Edwin_Lopez.Ejemplo_switch;
using static Proyecto1_semana3_Edwin_Lopez.Ejemplo_For;
using static Proyecto1_semana3_Edwin_Lopez.Ejemplo_DoWhile;
using static Proyecto1_semana3_Edwin_Lopez.Ejemplo_While;
namespace Proyecto1_semana3_Edwin_Lopez 
{
    class Principal2
    {
        
        static void Main(string[] args)
        {
            System.Console.WriteLine("Programa Principal");
            System.Console.WriteLine("Primer Programa");

            System.Console.ReadKey();
            int repetir;
           
           
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
            System.Console.WriteLine("4.Ejemplo While");
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

        }
       
    }
    
}
