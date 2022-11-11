using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_en_clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name, NameUser, Gmail, Title;
            int edad, Password, ConfirmPassword;
            int Num1, Ancho, altura;
            Console.WriteLine("Introduzca su nombre");
            Name = Console.ReadLine();
            Console.WriteLine("Introduce tu edad");
            edad = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Introduce tu correo de Gmail");
            Gmail = Console.ReadLine();
            Console.WriteLine("Por favor, cree un titulo para la consola");
            Title = Console.ReadLine();
            Console.Title = Title;
            Console.WriteLine("Por favor Crea un nombre de usuario");
            NameUser = Console.ReadLine();
            Console.WriteLine("Crea una contraseña(recueradala la usaras mas adelante)");
            Password =Convert.ToInt16(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Ahora es necesario que confirmes tu contraseña");
            ConfirmPassword = Convert.ToInt16(Console.ReadLine());

            if (ConfirmPassword == Password)
            {
                Console.WriteLine("Muy bien ahora seleccione el color en que quiere que se muestren sus datos del 1-5");
                Console.WriteLine(" 1 = azul \t 2 = rojo \t 3 = verde \t 4 = amarillo \t 5 = morado \t por favor seleccione uno");
                Num1 = Convert.ToInt32(Console.ReadLine());

                switch (Num1)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    default:
                        Console.WriteLine("El numero no existe");
                        break;

                }
                Console.WriteLine("Del 10 al 50 seleccione el alto de la consola (solo se admiten cifras en decena. ej. 10..20....");
                altura = Convert.ToInt32(Console.ReadLine());
               
                switch (altura)
                {
                    case 10:
                        Console.WindowHeight = 10;
                        break;
                    case 20:
                        Console.WindowHeight = 20;
                        break;
                    case 30:
                        Console.WindowHeight = 30;
                        break;
                    case 40:
                        Console.WindowHeight = 40;
                        break;
                    case 50:
                        Console.WindowHeight = 50;
                        break;
                    default:
                        Console.WriteLine("Lo sentimos su numero no es aceptado por el sistema");
                        break;
                }
                Console.WriteLine("Del 10 al 50 seleccione el ancho de la consola (solo se admiten cifras en decena. ej. 10..20....");
                Ancho = Convert.ToInt32(Console.ReadLine());

                Console.WindowWidth = Ancho;
            }
            else
            {
                Console.WriteLine("Lo sentimos las contraseñas no coinsiden");
            }

            Console.Clear();
            Console.WriteLine("Datos de usuario \n Nombre de usuario: {0} \n nombre de usuario: {1}", Name, NameUser);
            Console.WriteLine("\n Edad {0}  \n correo {1}",edad, Gmail);
            Console.Read();
        }
    }
}
