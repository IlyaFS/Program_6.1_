using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_6._1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string urok = Console.ReadLine();
            string[] mas = urok.Split();
            string slovo = "";

            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i].Length > slovo.Length) ;
                {
                    slovo = mas[i];
                }
            }
            Console.WriteLine(slovo);
            Console.ReadKey();
        }
    }
}
