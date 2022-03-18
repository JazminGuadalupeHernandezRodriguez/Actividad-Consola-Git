using System;

namespace ActividadGitConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1 = 0; float n2 = 0;

            Console.WriteLine("Calculadora \r");
            Console.WriteLine("------------------------\n");

            Console.WriteLine("Ingrese un Numero:");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese otro Numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());
        }
    }
}
