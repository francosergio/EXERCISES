using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS.@class
{
    internal class ThirtExercise
    {
        private int var=0;
        public void  saludar()
        {
            Console.WriteLine("hola, estas en el bloque para aprender las tablas de multiplicar, digita el numero que quieres aprender");
            int valToMultiplicate= Convert.ToInt32(Console.ReadLine());
            var = 0;
            do
            {
                Console.WriteLine($"{var} x {valToMultiplicate} = {(var*valToMultiplicate)}");
                var++;
            } while (var<=12);
        }
    }
}
