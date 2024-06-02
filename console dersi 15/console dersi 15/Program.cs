using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_dersi_15
{
    internal class Program
    {
        int topla(int a,int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Program mtr = new Program();
            int z,a,b;
            Console.WriteLine("iki deger girin:");
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());
            z=mtr.topla(a, b);
            Console.WriteLine("toplamı:"+z);
            Console.ReadLine();
        }
    }
}
