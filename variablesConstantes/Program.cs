using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variablesConstantes
{
    class Program
    {
        static void Main(string[] args)
        {
            //SumaYPromedio();
            //perimetroCuadrado();
            menuTeoremaDePitagoras();
            Console.ReadKey();

        }
        static void menuTeoremaDePitagoras()
        {
            Console.Clear();
            ImprimirTexto("Si desea calcular la hipotenusa ingrese 1");
            ImprimirTexto("Si desea calcular el cateto opuesto ingrese 2");
            ImprimirTexto("Si desea calcular el cateto adyacente ingrese 3");
            pitagoras(int.Parse(Console.ReadLine()));
        }

        static void perimetroCuadrado()
        {
            int lado, resultado;

            ImprimirTexto("Ingrese la medida de los lados de su cuadrado: ");
            lado = int.Parse(Console.ReadLine());
            resultado = lado * 4;
            ImprimirTexto("El perimetro de su cuadrado es: " + resultado);

        }

        static void SumaYPromedio()
        {
            int numero1, numero2, suma, promedio, producto ;

            ImprimirTexto("Ingrese el primer valor:");
            numero1 = int.Parse(Console.ReadLine());

            ImprimirTexto("Ingrese el segundo valor:");
            numero2 = int.Parse(Console.ReadLine());

            suma = numero1 + numero2;

            promedio = suma / 2;

            producto = numero1 * numero2;

            ImprimirTexto("La suma es: " + suma);
            ImprimirTexto("El promedio es: " + promedio);
            ImprimirTexto("El producto es: " + producto);

        }

        static void ImprimirTexto(string mensaje)
        {

            Console.WriteLine(mensaje);
        }

        static void pitagoras(int comando)
        {
            double hipotenusa, cateto1, cateto2;

            if (comando == 1 )
            {
                ImprimirTexto("Ingrese el primer cateto: ");
                cateto1 = double.Parse(Console.ReadLine());
                ImprimirTexto("Ingrese el segundo cateto: ");
                cateto2 = double.Parse(Console.ReadLine());
                
                hipotenusa = Math.Sqrt(Math.Pow(cateto1,2)+Math.Pow(cateto2,2));
                ImprimirTexto("La hipotenusa es de: " + hipotenusa);
            }
            else if (comando == 2)
            {

                ImprimirTexto("Ingrese la hipotenusa: ");
                hipotenusa = double.Parse(Console.ReadLine());
                ImprimirTexto("Ingrese el cateto adyacente: ");
                cateto1 = double.Parse(Console.ReadLine());
                if (cateto1 < hipotenusa)
                {
                    cateto2 = Math.Sqrt(Math.Pow(hipotenusa, 2) - Math.Pow(cateto1, 2));
                    ImprimirTexto("El valor del cateto opuesto es de: " + cateto2);
                }
                else
                {
                    ImprimirTexto("El valor del cateto no puede ser mayor a la hipotenusa");
                    Console.ReadKey();
                    menuTeoremaDePitagoras();
                }
            }else if (comando == 3)
            {
                ImprimirTexto("Ingrese la hipotenusa: ");
                hipotenusa = double.Parse(Console.ReadLine());
                ImprimirTexto("Ingrese el cateto opuesto: ");
                cateto2 = double.Parse(Console.ReadLine());
                if (cateto2 < hipotenusa)
                {
                    cateto1 = Math.Sqrt(Math.Pow(hipotenusa, 2) - Math.Pow(cateto2, 2));
                    ImprimirTexto("El valor del cateto adyacente es de: " + cateto1);
                }
                else
                {
                    ImprimirTexto("El valor del cateto no puede ser mayor a la hipotenusa");
                    Console.ReadKey();
                    menuTeoremaDePitagoras();
                }
            }
            else
            {
                ImprimirTexto("Ingrese un comando valido");
                Console.ReadKey();
                menuTeoremaDePitagoras();
            }
            

        }
    }
}
