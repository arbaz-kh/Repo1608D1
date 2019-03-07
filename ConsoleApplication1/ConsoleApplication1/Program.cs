using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            char opt;
            opt = Convert.ToChar(Console.ReadLine());

            switch(opt)
            {
                case 'a':
                    Console.WriteLine("\tZakat Finder");
                    Console.Write("Enter the Amount : ");
                    int amount;
                    amount = Convert.ToInt16(Console.ReadLine());
                    double zakat = amount * 0.025;
                    Console.WriteLine("Zakat to be pay : " + zakat);
                    break;
                case 'b':
                    Console.WriteLine("\tArea of Rectangle");
                    double length,width;
                    Console.Write("Length : ");
                    length = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Width : ");
                    width = Convert.ToDouble(Console.ReadLine());
                    double area = length * width;
                    Console.WriteLine("Area is " + area);
                    break;
            }
            Console.ReadKey();
        }
    }
}
