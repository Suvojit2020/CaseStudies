using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using record;

namespace solveQuestion
{
    internal class Q1
    {
        static void Main(string[] args)
        {
            try
            {
                int n;
                Console.WriteLine("Enter number of employees:");
                n=Convert.ToInt32(Console.ReadLine());
                Emp emp;

                List<Emp> EmpList = new List<Emp>();

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Write EmpId: ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Write nname: ");
                    string name = (Console.ReadLine());

                    Console.WriteLine("Write Address: ");
                    string add = (Console.ReadLine());

                    Console.WriteLine("Write city: ");
                    string city = (Console.ReadLine());

                    Console.WriteLine("Write Department: ");
                    string dept = (Console.ReadLine());

                    Console.WriteLine("Write Salary: ");
                    decimal salary = Convert.ToDecimal(Console.ReadLine());

                    emp = new Emp { EmployeeId = id, EmpName = name, Address = add, City = city, Department = dept, Salary = salary };
                    EmpList.Add(emp);
                }
                foreach (Emp i in EmpList)
                {
                    Console.WriteLine("{0},{1},{2},{3},{4},{5}", i.EmployeeId, i.EmpName, i.Address, i.City, i.Department, i.Salary);
                }
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch
            {
                Console.WriteLine("SomeThing Broken");
            }
           





        }
    }
}
