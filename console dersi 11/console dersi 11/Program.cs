using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_dersi_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] dizi = new int[3, 3];
            Console.WriteLine("lütfen matrisinizi olusturun:");
            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    dizi[i, k] = Convert.ToInt32(Console.ReadLine());
                }
            }

           for(int j=0;j<3;j++)
           {
                for(int l = 0; l < 3; l++)
                {
                    Console.Write("{0} ",dizi[j,l]);
                }
                Console.WriteLine();
           }
            Console.ReadLine();
        }
    }
}
