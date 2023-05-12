using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//  1.Suma de los primeros n números naturales: 
//       Escribe un programa que solicite al usuario un número entero positivo n, y luego
//       calcule la suma de los primeros n números naturales. Puedes utilizar un ciclo for o while para realizar la suma.

namespace EJERCICIOS.@class
{
    public class FirstExercise
    {

        public int Factorial()
        {
            Console.WriteLine("Buen día, ingresa un numero al que desea sacarle el factorial");
            int numberToAdd = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            int sumatoryVar = 0;

            do
            {
                result = result * sumatoryVar;
                sumatoryVar++;

            } while (sumatoryVar <= numberToAdd);

            Console.WriteLine($"valor: {result}");
            return result;

        }
        public int SerialSumatory()
        {
            Console.WriteLine("Buen día, ingresa un numero a sumar");
            int numberToAdd = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            int sumatoryVar = 0;

            do
            {
                result = result + sumatoryVar;
                sumatoryVar++;

            } while (sumatoryVar <= numberToAdd);

            Console.WriteLine($"valor: {result}");
            return result;
        }






    }

}
