using System;
using System.Diagnostics.SymbolStore;
using System.Runtime.ConstrainedExecution;
using Catalog;

namespace Q4
{
    public class Program
    {
        static void Main(string[] args)
        {
            int choice;
            car[] cars = new car[100];
            int totalCarsInCatalog = 0;
            string make;
            string model;
            int year;
            double salePrice;
            int ID;
            bool ch = true;
            while (ch)
            {
                Console.WriteLine("1. Adding a new car");
                Console.WriteLine("2. Modify the details of a particular car");
                Console.WriteLine("3. Search for a particular car in the Catalog");
                Console.WriteLine("4. List all the cars in the Catalog");
                Console.WriteLine("5. Delete a car from the Catalog");
                Console.WriteLine("6. Quit");

                Console.Write("Select one menu item: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
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
                        break;
                    case 2:
                        {
                            //Modify the details of a particular car
                            if (totalCarsInCatalog > 0)
                            {
                                Console.WriteLine("{0,10}{1,15}{2,15}{3,15}{4,15}", "ID", "Make", "Model", "Year", "Sale Price");
                                for (int i = 0; i < totalCarsInCatalog; i++)
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
                        break;
                    case 3:
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
                        break;
                    case 4:
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
                        break;
                    case 5:
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
                                    for (int i = ID; i <= totalCarsInCatalog ; i++)
                                    {
                                        cars[i] = cars[i+1];
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
                        break;
                    case 6:     ch = false;
                        break;
                }
            }

        }
    }


}

