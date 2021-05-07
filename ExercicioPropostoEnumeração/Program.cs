using System;
using ExercicioPropostoEnumeração.Entities;
using ExercicioPropostoEnumeração.Entities.Enums;
using System.Globalization;

namespace ExercicioPropostoEnumeração
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Client data");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("BirthDate (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
           
            Console.WriteLine("Enter the order data");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            
            Client c1 = new Client(name, email, birthDate);
            Order order = new Order(DateTime.Now, status, c1);

            Console.Write("How many itens to this order? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #1 item data: ");
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, productPrice);
                
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, productPrice, product);

                order.AddItem(orderItem);
            }
        }
    }
}

