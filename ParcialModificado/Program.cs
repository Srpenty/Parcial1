using System;
using System.Collections;

namespace ParcialModificado
{
    class Program
    {
        static void Main(string[] args)
        {
            int Op = 0;
            do
            {
                int numestudiantes;
                ArrayList registro = new ArrayList();
                string nombre;
                string apellido;
                int edad;
                double nota1;
                double nota2;
                double parcial;
                double promedio;
                int contador = 0;
                Console.WriteLine("Ingrese el numero de studiantes");
                numestudiantes = int.Parse(Console.ReadLine());

                while (contador < numestudiantes)
                {
                    Console.Write("Ingrese el nombre del estudiante: ");
                    nombre = Console.ReadLine();
                    Console.Write("Ingrese el apellido del estudiante: ");
                    apellido = Console.ReadLine();
                    Console.Write("Ingrese la edad del estudiante: ");
                    edad = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la nota del estudiante: ");
                    nota1 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la segunda nota del estudiante: ");
                    nota2 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la nota del parcial del estudiante: ");
                    parcial = int.Parse(Console.ReadLine());
                    promedio = (nota1 * 0.3) + (nota2 * 0.3) + (parcial * 0.4);
                    new Estudiantes(nombre, apellido, edad, promedio); 
                    contador++;

                    if (promedio >= 6)
                    {
                        Console.WriteLine("Aprobado");
                    }
                    else
                    {
                        Console.WriteLine("Reprobado");
                    }
                }
                foreach (Estudiantes estus in registro)
                {
                    Console.WriteLine(estus.getdata());
                }
                Console.WriteLine("Si desea agregar otro estudiante precione 0, si desea salir precione cualquier otro numero");
                Op = int.Parse(Console.ReadLine());
            } while (Op == 0);
        }
    }
}
