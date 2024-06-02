using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_dersi_13
{
    internal class Program
    {
        private static void yazdir(string bilgi)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(bilgi);
            }  
    }

        static void Main(string[] args)
        {
            Console.Write("lutfen bi yazı giriniz:");
            string yazı = Console.ReadLine();
            yazdir(yazı);
            Console.Read();           
        }
    }
}
