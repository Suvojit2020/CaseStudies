using Corporate_University;
using System;

namespace solveQuestion3
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Participants emp = new Participants();
            Console.WriteLine("Enter Employee Details");
            try
            {

                int num;
                bool ch = true;
                while (ch)
                {
                    Console.WriteLine("1.Add Corporate_University   2.Display    3.Exit");
                    num=Convert.ToInt32(Console.ReadLine());
                    switch (num)
                    {

                        case 1:
                            {
                                Console.Write("Employee ID : ");
                                int Id = Convert.ToInt32(Console.ReadLine());

                                Console.Write("Foundation Marks : ");
                                int FoundMarks = Convert.ToInt32(Console.ReadLine());

                                Console.Write("WebBasic Marks : ");
                                int WebMarks = Convert.ToInt32(Console.ReadLine());

                                Console.Write(".Net Marks : ");
                                int DotNetMarks = Convert.ToInt32(Console.ReadLine());

                                emp = new Participants { _EmpId = Id, _FoundationMarks = FoundMarks, _WebBasicMarks = WebMarks, _DotNetMarks = DotNetMarks };

                            }
                            break;

                        case 2:
                            {
                                Console.WriteLine("TotalObtainedMarks : {0}", emp.TotalMarks());
                                Console.WriteLine("Percentage : {0}", emp.Percentage());
                            }
                            break;

                        case 3:
                            {
                                ch = false;
                            }
                            break;

                    }






                    }

            }

            catch (FormatException e) 
            {
                //  Console.WriteLine("Only Type Integer Value");
                Console.WriteLine(e.Message);


            }
            catch
            {
                Console.WriteLine("SomeThing Broken");
            }



        }
    }
}