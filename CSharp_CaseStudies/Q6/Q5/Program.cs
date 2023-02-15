using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using BankDetails;
namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //ICICI newIcic = new ICICI(BankAccountTypeEnum.Saving);
            Console.WriteLine("-----------------ICICI----------------");
            ICICI newIcic = new ICICI(BankAccountTypeEnum.Saving);
            Console.Write("Deposit Amount:");
            newIcic.Deposit(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Type of account: {0}",newIcic.AccountType);
            Console.Write("Withdraw Amount:");
            newIcic.Withdraw(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();
            newIcic.AccountType = BankAccountTypeEnum.Saving;
            newIcic.CalculateInterest();




            Console.WriteLine("-----------------HSBC----------------");
            HSBC newHsbc = new HSBC(BankAccountTypeEnum.Current);
            Console.Write("Deposit Amount:");
            newHsbc.Deposit(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Withdraw Amount:");
            newHsbc.Transfer(newIcic, Convert.ToInt32(Console.ReadLine()));
            newHsbc.CalculateInterest();


            Console.WriteLine("HSBC account balance: {0}",newHsbc.GetBalance());
            Console.WriteLine("ICIC account balance: {0}",newIcic.GetBalance());



        }
    }
}