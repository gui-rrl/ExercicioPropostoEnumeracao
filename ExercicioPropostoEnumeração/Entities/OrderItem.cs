using System;
using System.Collections.Generic;
using System.Text;
using ExercicioPropostoEnumeração.Entities.Enums;

namespace ExercicioPropostoEnumeração.Entities
{
    class OrderItem
    {

        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        
        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double Subtotal()
        {
            return Quantity * Price;
        }
    }
}
