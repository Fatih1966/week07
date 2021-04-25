using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W7D1
{
    class Program
    {

        public delegate int MyDelegate(int sayi1, int sayi2);

        static int Carp(int sayi1,int sayi2)
        {
            return sayi1 * sayi2;
        }


        static void Main(string[] args)
        {
            MyDelegate delege = new MyDelegate(Carp);
            int carpim = delege(3, 5);
            Console.WriteLine(carpim);
        }
    }
}
