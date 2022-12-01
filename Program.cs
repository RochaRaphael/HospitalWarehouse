using HospitalWarehouse.DataContext;
using HospitalWarehouse.Models;

namespace HospitalWarehouse
{
    class program
    {

        static void Main(string[] args)
        {
            void MainMenu()
            {
                Console.WriteLine("WELCOME TO HOSPITAL WAREHOUSE");
                Console.WriteLine();
                Console.WriteLine("CHOOSE AN OPTION");
                Console.WriteLine("1- Insert Product");
                Console.WriteLine("2- Use Product");
                Console.WriteLine("3- Exit");
            }


            int option = 1;
            while (option < 3 && option >= 0)
            {
                Console.Clear();
                MainMenu();
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:

                        break;

                    case 2:

                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("BYE, SEE YOU SOON!");
                        break;

                    default:
                        Console.WriteLine("Invalid option. enter a number from 1 to 7");
                        option = 0;
                        break;
                }
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
        }
    }
}