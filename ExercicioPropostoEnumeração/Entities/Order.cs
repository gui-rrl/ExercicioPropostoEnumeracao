﻿using System;
using System.Collections.Generic;
using System.Text;
using ExercicioPropostoEnumeração.Entities.Enums;

namespace ExercicioPropostoEnumeração.Entities
{
    class Order
    {
        
        public DateTime Moment { get; set; }
        public OrderStatus Status {get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }
        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client) { 
            Moment = moment;
            Status = status;
            Client = client;

        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public void Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in Items)
            {
                sum += item.Subtotal(); 
            }
        }
    }   
}
