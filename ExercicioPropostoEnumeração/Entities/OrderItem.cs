using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPropostoEnumeração.Entities
{
    class OrderItem
    {

        public int Quantity { get; set; }
        public double Price { get; set; }

        public double Subtotal (double subtotal)
        {
            return subtotal += Quantity * Price;
        }
    }
}
