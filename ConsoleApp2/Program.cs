using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ex1
            /*int a = 3;
            int b = (a = 2) * a;
            int c = b * (b = 5);
            Console.WriteLine("a =" + a + ", b =" + b + ", c =" + c);
            Console.Read();*/
            //in a 2a expresie se modifica a=2 ; si rezulta b=4
            // apoi c = 4 *5 = 20
            //la final a=2, b=5, c=20


            //ex2
            /*double d = 2.95;
            int i = 4;
            Console.WriteLine(++d > i ? d : i);
            Console.Read();*/
            //se compileaza. inseamna daca d incrementat >i, afiseaza d, altfel i.  afiseaza la final 4


            //ex3
            /*int a = 3;
            if (++a < 4)
                if (a++ < 4)
                    Console.WriteLine(a);
                else
                    Console.WriteLine(a);
            Console.Read();*/
            //+aa=4, deci conditia este falsa. nu afiseaza nimic, deoarece mai lipseste un statement else cu ce sa afiseze daca este fals.

            //ex4
            /*int suma = 0;
            for (int i = 1; i < 10; i++)
            {
                suma = suma + i;
            }
            Console.WriteLine("Suma este: " +suma);
            Console.Read();*/
            //suma=1+2+3+4+5+6+7+8+9 Suma este = 45

            //ex5
            /* int produs = 1;
             for (int x = 1; x < 13; x++) 
                      {
                 produs *= x;
                         }
             Console.WriteLine("n!, unde n<13 este: " +produs);
                 Console.Read();*/
            //

            //ex6
            /*int a = 200;
            int b = 30;
            int c = 400;
            if (a < b & a < c)
            {
                Console.WriteLine("cel mai mic numar este: " + a);
            }
            else if (a > b & b < c)
            { Console.WriteLine("cel mai mic numar este: " + b); }

            else 
             { Console.WriteLine("cel mai mic numar este: " + c);}
        Console.Read();*/

            //ex7
            /*  int a = 13;
              if (a%2==0)     
              { Console.WriteLine("Numarul este par") ; }
              else
              { Console.WriteLine("Numarul este impar"); }
              Console.Read();*/

            //ex8
            int caseSwitch = 6;
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Luni");
                    break;
                case 2:
                    Console.WriteLine("Marti");
                    break;
                case 3:
                    Console.WriteLine("Miercuri");
                    break;
                case 4:
                    Console.WriteLine("Joi");
                    break;
                case 5:
                    Console.WriteLine("Vineri");
                    break;
                case 6:
                    Console.WriteLine("Sambata");
                    break;
                case 7:
                    Console.WriteLine("Duminica");
                    break;
                default:
                    Console.WriteLine("csf, n-ai csf");
                    break;
                    Console.Read();
            }
        }
    }
}
