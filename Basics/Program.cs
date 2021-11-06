using System;

namespace Basics
{
    class Program // defualt class to console application
    {
        static void Main(string[] args) //this is the main function that console application run it 
        {
            // to comment shortcut : CTRL + K + C , to undo comment CTRL + K + U
            #region Person class
            //Person Client = new Person();

            //Console.WriteLine("first name");
            //Client.firstName = Console.ReadLine();

            //Console.WriteLine("last name");
            //Client.lastName = Console.ReadLine();

            //Console.WriteLine("birthday");
            //Client.birthDay = Convert.ToDateTime(Console.ReadLine());

            //Console.WriteLine("address");
            //Client.Address = Console.ReadLine();

            //Console.WriteLine("Height");
            //Client.height = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine(Client.FullName());
            //Console.WriteLine("his age is: " + Client.CalAge());
            #endregion

            #region Product class


            // Object of Product class
            //class name: Product + object name = new class
            //Product pepsi = new Product();
            Product prod = new Product();
            //Product Cleaning = new Product();
            //pepsi.name = "Seven";
            //Cleaning.name = "Plidage";

            Console.WriteLine("Product name");
            prod.name = Console.ReadLine();

            Console.WriteLine("Production date");
            //prod.prudactionDate = new DateTime(25 - 11 - 2021);
            prod.prudactionDate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Expire after:");
            prod.ExpireAfter = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Price");
            prod.Price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Cost");
            prod.Cost = Convert.ToDouble(Console.ReadLine());
            // CTRL +K + CTRL + D to formating

            Console.WriteLine("Profit is: " + prod.CalProfit());
            #endregion


        }


    }

}
