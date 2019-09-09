using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Comentari 78542*/

            /* Panic Error needs to be solved now */
            /* PANIC SOLVED */
            string nombre;
            double nota1, nota2, nota3;
            double promedio;

            Console.Write("Nombre del alumno:");
            nombre = (Console.ReadLine());

            Console.Write("Nota1:");
            nota1=double.Parse(Console.ReadLine());

            Console.Write("Nota2:");
            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Nota3:");
            nota3 = double.Parse(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3) / 3;
            Console.Write(nombre + " ha obtenido un promedio de: " + promedio.ToString("0.00"));

            Console.ReadLine();

        }
    }
}
