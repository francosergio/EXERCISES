using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//TITULO: 2.Contador de números pares e impares:
//    Escribe un programa que le pida al usuario un conjunto de números separados por comas y luego 
//    imprima el número total de números pares e impares en la lista. Puedes utilizar una estructura de control de flujo 
//    para separar los números y un contador para llevar la cuenta de los números pares e impares.

namespace EJERCICIOS.@class
{
    public class SecondExercise
    {
        public void Count() {
            Console.WriteLine("ingrese una lista de numeros separados con coma, para realizar el conteo de pares e impares");
            string readValues = Console.ReadLine();
            string[] values=readValues.Split(',');
          
            int contadorpares = 0;
            int contadorimpares = 0;

           foreach( string value in values)
            {
                if (Convert.ToInt32(value) % 2 == 0)
                {
                    contadorpares++;
                }
                else
                {
                    contadorimpares++;
                }

            }
           
            Console.WriteLine($"pares:{contadorpares} impares: {contadorimpares}");
           
        }
    }
}
