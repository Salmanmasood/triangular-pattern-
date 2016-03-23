using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rightangle_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to program....");
            int hYPO, pERP, bASE;
            Console.Write("Enter the side A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the side B: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter the side C: ");
            int c = int.Parse(Console.ReadLine());
            if (a>=b && a>=c)
            {
                hYPO = a;
                bASE = b;
                pERP = c;
                
            }
            else if (b>a && b>=c)
            {
                hYPO = b;
                bASE = a;
                pERP = c;
                
            }

            else
            {
                hYPO = c;
                bASE = a;
                pERP = b;
                
            }

            hYPO =(int) Math.Pow(hYPO, 2);
            bASE = (int)Math.Pow(bASE, 2);
            pERP = (int)Math.Pow(pERP, 2);
            int sum = bASE + pERP;
            if (sum==hYPO)
            {
                Console.WriteLine("TRIANGLE IS A Right angle triangle......");
                Console.ForegroundColor = ConsoleColor.Red;
                for (int i = 0; i <=10; i++)
                {
                    for (int j = i; j <= 10; j++)
                    {
                        Console.Write("*");    
                    }
                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine("TRIANGLE IS  not A Right angle triangle......");
                int m = 20, n = 1;
                Console.ForegroundColor = ConsoleColor.Red;
                for (int y = 0; y <= 20; y++) // outer loop
                {

                    for (int i = 1; i <= m; i++) // space printer
                    {
                        Console.Write(" ");
                    }

                    for (int j = 1; j <= n; j++)
                    {
                        Console.Write("*");
                    }
                    n = n + 2;
                    m--;
                    Console.WriteLine();


                }

            }


            Console.ReadLine();

        }
    }
}
