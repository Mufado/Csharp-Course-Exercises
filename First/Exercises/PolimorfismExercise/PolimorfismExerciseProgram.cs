using System;
using System.Collections.Generic;
using System.Globalization;

namespace First.Exercises.PolimorfismExercise
{
    class PolimorfismExerciseProgram
    {
        public void PolimorfismExercise()
        {
            Console.Write("Enter the number of products: ");
            int number_products = int.Parse(Console.ReadLine());
            var productsList = new List<Product>();
            for (int count = 1; count <= number_products; count++)
            {
                Console.WriteLine($"Product #{count} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char product_type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string product_name = Console.ReadLine();
                Console.Write("Price: ");
                double product_price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (product_type == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime product_manufacturedate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    productsList.Add(new UsedProduct(product_name, product_price, product_manufacturedate));
                }
                else if (product_type == 'i')
                {
                    Console.Write("Customs fee: ");
                    double products_customsfee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    productsList.Add(new ImportedProduct(product_name, product_price, products_customsfee));
                }
                else
                {
                    productsList.Add(new Product(product_name, product_price));
                }
            }

            Console.WriteLine("\nPRICE TAGS:");
            foreach (var product in productsList)
            {
                Console.WriteLine(product.priceTag());
            }
        }
    }
}
