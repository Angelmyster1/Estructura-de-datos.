using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resta_multiplicacion_division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            arreglo1();
            void arreglo1()
            {
                decimal[] a1 = new decimal[5];
                decimal[] a2 = new decimal[5];
                decimal res = 0;
                Console.WriteLine("¿Que operación quiere realizar? \n 1 = Resta \n 2 = Multiplicacion \n 3 = Division");
                decimal respuesta = decimal.Parse(Console.ReadLine());
                Console.Clear();
                while (respuesta != 0)
                {
                    switch (respuesta)
                    {
                        case 1: operacion_resta();
                            Console.WriteLine("1 = Volver a intentar resta \n2 = multiplicacion \n3= Division \n0 = Salir");
                            respuesta = decimal.Parse(Console.ReadLine());
                            break;
                        case 2: operacion_multipliacion();
                            Console.WriteLine("1 = Resta \n2 = Vaolver a intentar multiplicacion \n3= Division \n0 = Salir");
                            respuesta = decimal.Parse(Console.ReadLine());
                            break;
                        case 3: operacion_division();
                            Console.WriteLine("1 = Resta \n2 = multiplicacion \n3= Volver a intentar Division \n0 = Salir");
                            respuesta = decimal.Parse(Console.ReadLine());
                            break;
                        default:
                            Console.WriteLine("Elija una de las opciones anteriores");
                            respuesta = decimal.Parse(Console.ReadLine());
                            break;
                    }
                }
                void operacion_resta()
                {
                    Console.WriteLine("Resta de números");
                    for (int i = 0; i < a1.Length && i < a2.Length; i++)
                    {
                        Console.WriteLine("Vuelta #{0}", i);
                        //Arreglo 1
                        Console.WriteLine("Ingrese el valor #1: ");
                        res = decimal.Parse(Console.ReadLine());
                        a1[i] = res;
                        //Arreglo 2
                        Console.WriteLine("Ingrese el valor #2: ");
                        res = decimal.Parse(Console.ReadLine());
                        a2[i] = res;
                        Console.Clear();
                    }
                    for (int i = 0; i < a1.Length && i < a2.Length; i++)
                    {
                        decimal resta = a1[i] - a2[i];
                        Console.WriteLine("{0} + {1} = {2}", a1[i], a2[i], resta);
                    }
                }
                void operacion_multipliacion()
                {
                    Console.WriteLine("Multiplicacion de números");
                    for (int i = 0; i < a1.Length && i < a2.Length; i++)
                    {
                        Console.WriteLine("Vuelta #{0}", i);
                        //Arreglo 1
                        Console.WriteLine("Ingrese el valor #1: ");
                        res = decimal.Parse(Console.ReadLine());
                        a1[i] = res;
                        //Arreglo 2
                        Console.WriteLine("Ingrese el valor #2: ");
                        res = decimal.Parse(Console.ReadLine());
                        a2[i] = res;
                        Console.Clear();
                    }
                    for (int i = 0; i < a1.Length && i < a2.Length; i++)
                    {
                        decimal resta = a1[i] * a2[i];
                        Console.WriteLine("{0} X {1} = {2}", a1[i], a2[i], resta);
                    }
                }
                void operacion_division()
                {
                    Console.WriteLine("Division de números");
                    for (int i = 0; i < a1.Length && i < a2.Length; i++)
                    {
                        Console.WriteLine("Vuelta #{0}", i);
                        //Arreglo 1
                        Console.WriteLine("Ingrese el valor #1: ");
                        res = decimal.Parse(Console.ReadLine());
                        a1[i] = res;
                        //Arreglo 2
                        Console.WriteLine("Ingrese el valor #2: ");
                        res = decimal.Parse(Console.ReadLine());
                        a2[i] = res;
                        Console.Clear();
                    }
                    for (int i = 0; i < a1.Length && i < a2.Length; i++)
                    {
                        decimal resta = a1[i] / a2[i];
                        Console.WriteLine("{0} / {1} = {2}", a1[i], a2[i], resta);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
