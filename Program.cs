using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreMS
{
    class Program
    {
        class STORE
        {
            public string ID;
            public string name;
            public float price;
            public string category;
            public string brandName;
            public string country;
        }

        static void Main(string[] args)
        {
            STORE[] product = new STORE[3];
            int count = 0;
            char option;
            do
            {
                Console.Clear();
                option = menu();
                if (option == '1')
                {
                    product[count] = addProduct();
                    count++;

                }
                else if (option == '2')
                {
                    viewProducts(product, count);
                }
                else if (option == '3')
                {
                    float answer = storeWorth(product, count);
                    Console.WriteLine("Total Worth = {0}", answer);
                    Console.ReadKey();

                }
                else if (option == '4')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }

            } while (option != '4');

            Console.ReadKey();

        }

        static char menu()

        {
            char choice;
            Console.WriteLine("Press 1 to Add Product : ");
            Console.WriteLine("Press 2 to View Product : ");
            Console.WriteLine("Press 3 for Store Worth : ");
            Console.WriteLine("Press 4 to Exit : ");
            choice = char.Parse(Console.ReadLine());
            return choice;
        }

        static STORE addProduct()
        {
            Console.Clear();

            STORE p1 = new STORE();
            Console.WriteLine("Enter the ID : ");
            p1.ID = Console.ReadLine();

            Console.WriteLine("Enter the Name : ");
            p1.name = Console.ReadLine();

            Console.WriteLine("Enter the Price : ");
            p1.price = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Category : ");
            p1.category = Console.ReadLine();

            Console.WriteLine("Enter the Brand Name : ");
            p1.brandName = Console.ReadLine();

            Console.WriteLine("Enter the Country : ");
            p1.country = Console.ReadLine();

            return p1;

        }

        static void viewProducts(STORE[] product, int count)
        {
            Console.Clear();

            if (count == 0)
            {
                Console.WriteLine("No Product Yet");
            }

            else
            {
                for (int i = 0; i < count; i++)
                {


                    Console.WriteLine("ID {0} Name {1} Price {2} Category {3} Brand Name {4} Country {5}", product[i].ID, product[i].name, product[i].price, product[i].category, product[i].brandName, product[i].country);
                  
                
                }
            }
            Console.ReadKey();

        }

        static float storeWorth(STORE[] product, int count)
        {
            Console.Clear();

            float total = 0;

            if (count == 0)
            {
                Console.WriteLine("No Product Yet");
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    total = total + product[i].price;
                }
            }
            return total;
        }

    }
}
