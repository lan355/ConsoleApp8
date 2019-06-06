using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
         static void Main(string[] args)
            {

                Thread flowA = new Thread(MovingA);
                flowA.Start();
                Thread flowB = new Thread(MovingB);
                flowB.Start();
                Thread flowC = new Thread(MovingC);
                flowC.Start();
            }

            static void MovingA()
            {
                int x = 3;
                int y = 5;
                while (x <= 120)
                {
                    try
                    {
                        x++;
                        Console.Clear();
                        Console.SetCursorPosition(x, y);
                        Console.Write("1");


                    }
                    catch
                    {
                        break;
                    }
                }
            }

            static void MovingB()
            {
                int x = 2;
                int y = 10;
                while (x <= 120)
                {
                    try
                    {
                        x++;
                        Console.Clear();
                        Console.SetCursorPosition(x, y);
                        Console.Write("2");


                    }
                    catch
                    {
                        break;
                    }


                }
            }

            static void MovingC()
            {
                int x = 1;
                int y = 15;
                while (x <= 120)
                {

                    try
                    {
                        x++;
                        Console.Clear();
                        Console.SetCursorPosition(x, y);
                        Console.Write("3");


                    }
                    catch
                    {
                        break;
                    }

                }
            }

    }
}

