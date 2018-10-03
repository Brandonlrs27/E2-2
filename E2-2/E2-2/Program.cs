using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace E2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lares Dominguez Brandon - 17211532
            int val = 1;
            Fibonacci Fibo = new Fibonacci();
            Console.WriteLine("Recursividad: ");
            Console.Write("Cuantos numeros fibonacci quieres: ");
            int rec = int.Parse(Console.ReadLine());
            DateTime Inicio = DateTime.Now;
            while (val <= rec )
            {
            Console.WriteLine(Fibo.Recursividad(val));
            val++;
            }
            TimeSpan tiempo = DateTime.Now - Inicio;          
            Console.WriteLine(tiempo.Milliseconds + " milisegundos");
            Console.WriteLine("");
            Fibo.Iterativo();
            Console.ReadKey();
        }
    }
    class Fibonacci
    {
        public int Fibo = 0, Primera = 0, Ultima = 1;
        public int Recursividad (int num)
        {
           if (num < 2)
           {
                return num;
           }
           else
           {
                return Recursividad(num - 1) + Recursividad(num - 2);
           }
        }
        public void Iterativo ()
        {
            Console.WriteLine("Iterativo: ");
            Console.Write("Cuantos numeros fibonacci quieres: ");
            int ite = Convert.ToInt16(Console.ReadLine());
            DateTime Inicio = DateTime.Now;
            for (int i = 0; i < ite; i++)
            {
                Fibo = Primera;
                Primera = Ultima;
                Ultima = Primera + Fibo;
                Console.WriteLine(Primera);
            }
            TimeSpan tiempo = DateTime.Now - Inicio;
            Console.WriteLine(tiempo.Milliseconds + " milisegundos");
        }

    }
}