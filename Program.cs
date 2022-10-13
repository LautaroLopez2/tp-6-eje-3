using System;

namespace tp_6_eje_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string nombre = "Lautaro";
            int num;
            float coma, decimales;
            bool booleana = true;

            num = 200;
            coma = 18.9f;
            decimales = 1.5f;

            Console.WriteLine("Su nombre es {0} ", nombre);
            Console.ReadKey();
            Console.WriteLine("Su numero es {0}", num);
            Console.ReadKey();
            Console.WriteLine("Su numero Real {0}", coma);
            Console.ReadKey();
            Console.WriteLine("Su numero decimal {0}", decimales);
            Console.ReadKey();
            Console.WriteLine("La siguiente afirmacion es {0}", booleana);

        }
    }
}
