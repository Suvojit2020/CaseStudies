/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Class1
    {


                    while (choice.CompareTo("6") != 0)
            {
                Console.WriteLine("1. Adding a new car");
                Console.WriteLine("2. Modify the details of a particular car");
                Console.WriteLine("3. Search for a particular car in the Catalog");
                Console.WriteLine("4. List all the cars in the Catalog");
                Console.WriteLine("5. Delete a car from the Catalog");
                Console.WriteLine("6. Quit");


                Console.Write("Select one menu item: ");
                choice = Console.ReadLine();
                if (choice.CompareTo("1") == 0)
                {
                    //Adding a new car
                    Console.Write("Enter make of a car: ");
                    make = Console.ReadLine();
                    Console.Write("Enter model of a car: ");
                    model = Console.ReadLine();
                    Console.Write("Enter year of a car: ");
                    year = int.Parse(Console.ReadLine());
        Console.Write("Enter sale price of a car: ");
                    salePrice = double.Parse(Console.ReadLine());
        cars[totalCarsInCatalog] = new car(make, model, year, salePrice);
        totalCarsInCatalog++;
                }
                else if (choice.CompareTo("2") == 0)
                {
                    //Modify the details of a particular car
                    if (totalCarsInCatalog > 0)
                    {
                        Console.WriteLine("{0,10}{1,15}{2,15}{3,15}{4,15}", "ID", "Make", "Model", "Year", "Sale Price");
                        for (int i = 0; i<totalCarsInCatalog; i++)
                        {
                            Console.WriteLine("{0,10}{1,15}{2,15}{3,15}{4,15}", (i + 1), cars[i].Make, cars[i].Model, cars[i].Year, cars[i].SalePrice);
                        }
Console.Write("Enter ID of a car you want to edit: ");
ID = int.Parse(Console.ReadLine());
ID--;
if (ID >= 0 && ID < totalCarsInCatalog)
{
    Console.Write("Enter a new make of a car: ");
    make = Console.ReadLine();
    Console.Write("Enter a new model of a car: ");
    model = Console.ReadLine();
    Console.Write("Enter a new year of a car: ");
    year = int.Parse(Console.ReadLine());
    Console.Write("Enter a new sale price of a car: ");
    salePrice = double.Parse(Console.ReadLine());
    cars[ID] = new car(make, model, year, salePrice);
    Console.WriteLine("\nSelected car has been updated.\n");
}
else
{
    Console.WriteLine("\nSelect correct ID.\n");
}
                    }
                }
                else if (choice.CompareTo("3") == 0)
{
    //Search for a particular car in the Catalog
    if (totalCarsInCatalog > 0)
    {
        Console.Write("Enter make or model of a car you want to search: ");
        make = Console.ReadLine();
        Console.WriteLine("{0,10}{1,15}{2,15}{3,15}{4,15}", "ID", "Make", "Model", "Year", "Sale Price");
        for (int i = 0; i < totalCarsInCatalog; i++)
        {
            bool isFound = false;
            if (cars[i].Make.CompareTo(make) == 0 || cars[i].Model.CompareTo(make) == 0)
            {
                Console.WriteLine("{0,10}{1,15}{2,15}{3,15}{4,15}", (i + 1), cars[i].Make, cars[i].Model, cars[i].Year, cars[i].SalePrice);
                isFound = true;
            }
            if (!isFound)
            {
                Console.WriteLine("\nThe car with such make or model does not exist.\n");
            }
        }
    }
}
else if (choice.CompareTo("4") == 0)
{
    //List all the cars in the Catalog
    if (totalCarsInCatalog > 0)
    {
        Console.WriteLine("{0,10}{1,15}{2,15}{3,15}{4,15}", "ID", "Make", "Model", "Year", "Sale Price");
        for (int i = 0; i < totalCarsInCatalog; i++)
        {
            Console.WriteLine("{0,10}{1,15}{2,15}{3,15}{4,15}", (i + 1), cars[i].Make, cars[i].Model, cars[i].Year, cars[i].SalePrice);
        }
    }
}
else if (choice.CompareTo("5") == 0)
{
    // Delete a car from the Catalog
    if (totalCarsInCatalog > 0)
    {
        Console.WriteLine("{0,10}{1,15}{2,15}{3,15}{4,15}", "ID", "Make", "Model", "Year", "Sale Price");
        for (int i = 0; i < totalCarsInCatalog; i++)
        {
            Console.WriteLine("{0,10}{1,15}{2,15}{3,15}{4,15}", (i + 1), cars[i].Make, cars[i].Model, cars[i].Year, cars[i].SalePrice);
        }
        Console.Write("Enter ID of a car you want to delete: ");
        ID = int.Parse(Console.ReadLine());
        ID--;
        if (ID >= 0 && ID < totalCarsInCatalog)
        {
            for (int i = ID; i < totalCarsInCatalog - 1; i++)
            {
                cars[i] = cars[i + 1];
            }
            totalCarsInCatalog--;
            Console.WriteLine("\nSelected car has been deleted.\n");
        }
        else
        {
            Console.WriteLine("\nSelect correct ID.\n");
        }
    }
}
else if (choice.CompareTo("6") == 0)
{
    //exit
}
else
{
    Console.WriteLine("Select correct menu item.");
}
            }
    }
}
*/