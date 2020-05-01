using System;
using ToDoOrder.Entities.Enums;
using ToDoOrder.Entities;
using System.Globalization;

namespace ToDoOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Status (PENDINNG_PAYMENT,PROCESSING,SHIIPPED,DELIVERED): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine().ToUpper());

            Client client = new Client(name, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int qtdeItems = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdeItems; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int qtde = int.Parse(Console.ReadLine());

                Product product = new Product(nameProduct, price);
                OrderItem item = new OrderItem(qtde, price, product);

                order.AddItem(item);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMARY:");
            Console.WriteLine(order);
        }
    }
}
