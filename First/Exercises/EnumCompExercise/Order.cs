using First.Exercises.EnumCompExercise.Enums;
using System;
using System.Collections.Generic;

namespace First.Exercises.EnumCompExercise
{
    class Order
    {
        public DateTime Moment { get; set; }
        public EOrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order()
        {
        }

        public Order(EOrderStatus status, Client client)
        {
            Moment = DateTime.Now;
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

        public double Total()
        {
            double totalPrice = 0;
            foreach (var item in Items)
            {
                totalPrice += item.SubTotal();
            }
            return totalPrice;
        }
    }
}
