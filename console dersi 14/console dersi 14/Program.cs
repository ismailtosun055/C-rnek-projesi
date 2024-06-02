using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_dersi_14
{
    internal class Program
    {
        private static int topla(int x, int y)
        {
            int t= x + y;
            return t;
        }
        static void Main(string[] args)
        {
            int sayi1,sayi2;
            Console.Write("sayi1 giriniz:");
            sayi1=Convert.ToInt32(Console.ReadLine());
            Console.Write("sayi2 giriniz:");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("toplamın sonucu:"+topla(sayi1,sayi2));
            Console.Read();

        }
    }
}
