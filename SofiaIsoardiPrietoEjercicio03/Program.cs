using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofiaIsoardiPrietoEjercicio03
{
    class Program
    {
        static void Main(string[] args)
        {

            double  mayorGrados, promedioTemp, suma;
            int contador, contadorDeseado;

            mayorGrados = -90;
            contador = 0;
            suma = 0;

            Console.WriteLine("Cuantas temperaturas en ºCelsius desea ingresar?");
            contadorDeseado = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("Ingrese la temperatura en ºCelsius de entre -70 a 60");
                var gradosCelsius = Convert.ToDouble(Console.ReadLine());

               
                if (gradosCelsius>=-70 && gradosCelsius<=60)
                {
                    suma = suma + gradosCelsius;
                    contador = contador+1;
                   
                    if (gradosCelsius>mayorGrados)
                    {
                        mayorGrados = gradosCelsius;

                    }
                    else
                    {

                    }

                }
                else
                {
                    Console.WriteLine("Temperatura ingresada fuera del rango permitido");
                }

                var gradosFahrenheit = 1.8 * gradosCelsius + 32;
                Console.WriteLine($"La temperatura {gradosCelsius}ºC es igual a {gradosFahrenheit} ");



            } while (contador<contadorDeseado);

            promedioTemp = suma / contador;

            Console.WriteLine($"La temperatura mayor resgistrada es de: {mayorGrados}");
            Console.WriteLine($"El promedio de temperaturas ingresadas es de: {promedioTemp}");
        }
    }
}
