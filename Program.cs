using System;

namespace ActividadGitConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1 = 0; float n2 = 0;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Calculadora \r");
            Console.WriteLine("------------------------\n");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Ingrese un Numero:");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese otro Numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Escoja una de las opciones de la lista:");
            Console.WriteLine("\ta - Añadir");
            Console.WriteLine("\ts - Subtraer");
            Console.WriteLine("\tm - Multiplicar");
            Console.WriteLine("\td - Dividir");
            Console.Write("Cual es tu opcion? ");


            Console.ForegroundColor = ConsoleColor.Yellow;
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Tu resultado: {n1} + {n2} = " + (n1 + n2));
                    break;
                case "s":
                    Console.WriteLine($"Tu resultado: {n1} - {n2} = " + (n1 - n2));
                    break;
                case "m":
                    Console.WriteLine($"Tu resultado: {n1} * {n2} = " + (n1 * n2));
                    break;
                case "d":
                    Console.WriteLine($"Tu resultado: {n1} / {n2} = " + (n1 / n2));
                    break;

            }
            Console.Write("Presione cualquier tecla para cerrar la calculadora");
            Console.ReadKey();

        }
    }
}
