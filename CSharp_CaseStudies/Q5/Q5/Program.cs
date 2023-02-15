using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    abstract class Question5
    {
        public int empId;
        public string empNam;
        public string address;
        public string city;
        public string department;
        public double salary { get; set; }
        public Question5(int empId, string empNam, string address, string city, string department, double salary)
        {
            this.empId = empId;
            this.empNam = empNam;
            this.address = address;
            this.city = city;
            this.department = department;
            this.salary = salary;
        }


        public Question5() { }
        public Question5(double s)
        {
            this.salary = s;
        }
        public abstract double GetSalary();
        static void Main(string[] args)
        {
            try
            {
                Question5 newEmp = null;
                int n = 0;
                while (n != 3)
                {
                    Console.WriteLine("Press 1 for contract employee");
                    Console.WriteLine("Press 2 for permanent employee");
                    Console.WriteLine("Press 3 for Exit");
                    Console.Write("Your choice: ");
                    n = int.Parse(Console.ReadLine());
                    if (n == 1)
                    {
                        newEmp = new ContractEmployee();
                        Console.WriteLine("Enter Employee ID : ");
                        newEmp.empId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee Name :");
                        newEmp.empNam = Console.ReadLine();
                        Console.WriteLine("Enter Employee Address :");
                        newEmp.address = Console.ReadLine();
                        Console.WriteLine("Enter Employee City :");
                        newEmp.city = Console.ReadLine();
                        Console.WriteLine("Enter Employee Department :");
                        newEmp.department = Console.ReadLine();
                        Console.Write("Enter the salary: ");
                        newEmp.salary = double.Parse(Console.ReadLine());
                        Console.Write("Enter the perks: ");
                        ((ContractEmployee)newEmp).Perks = double.Parse(Console.ReadLine());
                        Console.WriteLine("\n");
                        Console.WriteLine("Contract Employee ID {0}", newEmp.empId);
                        Console.WriteLine("Contract Employee Name {0}", newEmp.empNam);
                        Console.WriteLine("Contract Employee Address {0}", newEmp.address);
                        Console.WriteLine("Contract Employee City {0}", newEmp.city);
                        Console.WriteLine("Contract Employee Department {0}", newEmp.department);
                        Console.WriteLine("Contract Employee Salary without Perks: {0}", newEmp.salary.ToString());
                        Console.WriteLine("Contract Employee Perks: {0}", ((ContractEmployee)newEmp).Perks.ToString());
                        Console.WriteLine("Contract Employee Salary with Perks: {0}", newEmp.GetSalary().ToString());
                        Console.WriteLine("\n------------------------------------------\n");
                        break;
                    }

                    else if (n == 2)
                    {
                        newEmp = new PermanentEmployee();
                        Console.WriteLine("Enter Employee ID : ");
                        newEmp.empId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee Name :");
                        newEmp.empNam = Console.ReadLine();
                        Console.WriteLine("Enter Employee Address :");
                        newEmp.address = Console.ReadLine();
                        Console.WriteLine("Enter Employee City :");
                        newEmp.city = Console.ReadLine();
                        Console.WriteLine("Enter Employee Department :");
                        newEmp.department = Console.ReadLine();
                        Console.Write("Enter salary: ");
                        newEmp.salary = double.Parse(Console.ReadLine());
                        Console.Write("Enter the number of leaves: ");
                        ((PermanentEmployee)newEmp).NoOfLeaves = int.Parse(Console.ReadLine());
                        Console.Write("Enter the providend fund: ");
                        ((PermanentEmployee)newEmp).ProvidendFund = double.Parse(Console.ReadLine());
                        Console.WriteLine("\n");
                        Console.WriteLine("Contract Employee ID {0}", newEmp.empId);
                        Console.WriteLine("Contract Employee Name {0}", newEmp.empNam);
                        Console.WriteLine("Contract Employee Address {0}", newEmp.address);
                        Console.WriteLine("Contract Employee City {0}", newEmp.city);
                        Console.WriteLine("Contract Employee Department {0}", newEmp.department);
                        Console.WriteLine("Permanent Employee Salary with Providend fund: {0}", newEmp.salary.ToString());
                        Console.WriteLine("Permanent Employee No of leaves: {0}", ((PermanentEmployee)newEmp).NoOfLeaves);
                        Console.WriteLine("Permanent Employee Providend fund: {0}", ((PermanentEmployee)newEmp).ProvidendFund.ToString());
                        Console.WriteLine("Permanent Employee Salary without Providend fund: {0}", newEmp.GetSalary().ToString());
                        Console.WriteLine("\n------------------------------------------\n");
                        break;
                    }

                    else if (n == 3)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }



                }//while loop
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch
            {
                Console.WriteLine("Code Broken");
            }
           
         }//main
      }

    
    class ContractEmployee : Question5
    {
        public double Perks { get; set; }
        public ContractEmployee() { }
        public ContractEmployee(double p, double s): base(s)
        {
            this.Perks = p;
        }
        public override double GetSalary()
        {
            return salary + Perks;
        }
    }
    class PermanentEmployee : Question5
    {
        public int NoOfLeaves { get; set; }
        public double ProvidendFund { get; set; }
        public PermanentEmployee() { }
        public PermanentEmployee(int noOfLeaves, double providendFund, double salary): base(salary)
        {
            this.NoOfLeaves = noOfLeaves;
            this.ProvidendFund = providendFund;
        }
        public override double GetSalary()
        {
            return salary - ProvidendFund;
        }
    }
}