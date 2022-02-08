using First.Exercises.EnumCompExercise.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace First.Exercises.EnumCompExercise
{
    class EnumCompExerciseProgram
    {
        public void EnumCompExercise()
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string client_name = Console.ReadLine();
            Console.Write("Email: ");
            string client_email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime client_birthdate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            var client = new Client(client_name, client_email, client_birthdate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            var order_status = (EOrderStatus)Enum.Parse(typeof(EOrderStatus), Console.ReadLine());
            Console.Write("How many item to order? ");
            int order_orderitems_quantity = int.Parse(Console.ReadLine());

            var productsList = new List<Product>();
            var orderItemList = new List<OrderItem>();

            for (int items = 1; items <= order_orderitems_quantity; items++)
            {
                Console.WriteLine($"Enter #{items} item data:");
                Console.Write("Product name: ");
                string product_name = Console.ReadLine();
                Product inlistProduct = productsList.Find(prod => prod.Name == product_name);
                if (inlistProduct == null)
                {
                    Console.Write("Product price: ");
                    double product_price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Product product = new Product(product_name, product_price);
                    productsList.Add(product);
                    Console.Write("Quantity: ");
                    int orderitem_quantity = int.Parse(Console.ReadLine());
                    OrderItem orderItem = new OrderItem(orderitem_quantity, product);
                    orderItemList.Add(orderItem);
                }
                else
                {
                    Console.Write($"This product already exists. Product price is {inlistProduct.Price.ToString("F2",CultureInfo.InvariantCulture)}");
                    Console.Write("Quantity: ");
                    int orderitem_quantity = int.Parse(Console.ReadLine());
                    OrderItem orderItem = new OrderItem(orderitem_quantity, inlistProduct);
                    orderItemList.Add(orderItem);
                }
            }
            Console.WriteLine();

            Order order = new Order(order_status, client);
            foreach (var order_item in orderItemList)
            {
                order.Items.Add(order_item);
            }

            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine($"Order moment: {order.Moment}");
            Console.WriteLine($"Order status: {order.Status}");
            Console.WriteLine($"Client: {order.Client}");
            Console.WriteLine("Order items: ");
            foreach (var orderitem in order.Items)
            {
                Console.WriteLine(orderitem);
            }
            Console.WriteLine($"Total price: {order.Total().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
