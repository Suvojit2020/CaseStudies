using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewConsoleApp1
{
    class method
    {

        public void display(int[][] jagged)
        {
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.WriteLine("[{0}] [{1}] {2} ", i, j, jagged[i][j]);
                }
                Console.WriteLine();
            }
        }
        public void monthly(int[][] jagged) 
        {
            for (int i = 0; i < jagged.Length; i++)
            {
                int sum=0;
                for (int j = 0; j < jagged[i].Length; j++)
                {
                   sum= sum + jagged[i][j];
                }
                Console.WriteLine("{0} month Selling is {1}",i+1,sum);
                
            }
        }
        public void AnualWise(int[][] jagged)
        {
            int sum1 = 0;
            for (int i = 0; i < jagged.Length; i++)
            {
                
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    sum1 = sum1 + jagged[i][j];
                }
                

            }
            Console.WriteLine("Annual Selling is {0}",sum1);
        }
    }
   

    internal class ProgramSales
    {


        public static void Main()
        {
            try
            {
                int n;
                Console.WriteLine("Enter number of months");
                n = Int32.Parse(Console.ReadLine());
                int[][] jagged = new int[n][];

                bool ch = true;
                while (ch)
                {
                    Console.WriteLine("1.Add Sales Figure 2.Display all Jagged Array 3.Display Monthly wise 4.Display Anunal 5.Exit");
                    int num = Int32.Parse(Console.ReadLine());

                    switch (num)
                    {
                        case 1:
                            {
                                for (int i = 0; i < jagged.Length; i++)
                                {
                                    Console.WriteLine("Enter Number of Salesman of {0} month", i+1);
                                    int m = Int32.Parse(Console.ReadLine());
                                    jagged[i] = new int[m];
                                    for (int j = 0; j < m; j++)
                                    {
                                        Console.WriteLine("Enter sales of Saleman {0}",j+1);
                                        jagged[i][j] = Int32.Parse(Console.ReadLine());
                                    }
                                }
                            }
                            break;

                        case 2:
                            {
                                method obj = new method();
                                obj.display(jagged);
                            }
                            break;
                        case 3:
                            {
                                method obj1 = new method();
                                obj1.monthly(jagged);
                            }
                            break;
                        case 4:
                            {
                                method obj2 = new method();
                                obj2.AnualWise(jagged);
                            }
                            break;
                        case 5:
                            ch = false;
                            break;
                        default:
                            Console.WriteLine("Enter Wrong Input");
                            break;
                    }
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Only Type Integer Value");
            }
            catch
            {
                Console.WriteLine("SomeThing Broken");
            }
            
        }
    }
}
        
