using System;
using EJERCICIOS.@class;

namespace EJERCICIOS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> selection = new List<string>();
            Console.WriteLine("digite el  numero de ejercicio a visualizar:");
            int exerciseSelected = Convert.ToInt32(Console.ReadLine());

            switch ((ejercicioSeleccionado)exerciseSelected)
            {
                case ejercicioSeleccionado.ejercicio1:
                    FirstExercise valor= new FirstExercise();
                    int perro = valor.SerialSumatory();
                    break;
                case ejercicioSeleccionado.ejercicio2:
                    SecondExercise valor2 = new SecondExercise();
                    valor2.Count();
                    break;
                case ejercicioSeleccionado.ejercicio3:
                    ThirtExercise   valor3= new ThirtExercise();
                    valor3.saludar();

                    break;
                case ejercicioSeleccionado.ejercicio4:
                    Console.WriteLine($"{ejercicioSeleccionado.ejercicio4}");
                    break;
                case ejercicioSeleccionado.ejercicio5:
                    Console.WriteLine($"{ejercicioSeleccionado.ejercicio5}");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }
        }

enum ejercicioSeleccionado
{ 
    ejercicio1=1,
    ejercicio2=2,
    ejercicio3=3,
    ejercicio4=4,
    ejercicio5=5,
}
//En C#,
//un enum es un tipo de dato que se utiliza para definir una enumeración, es decir, 
//un conjunto de constantes con nombre y valores asociados.
//Los enum se definen mediante la keyword enum seguida del nombre de la enumeración y una 
//lista de constantes separadas por comas. Cada constante en un enum tiene un nombre y un 
//valor numérico asociado, que por defecto comienza en 0 y se incrementa en 1 para cada constante.



 }
 
}