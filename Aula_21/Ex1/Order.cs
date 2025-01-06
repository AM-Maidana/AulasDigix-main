using System;
namespace Ex1
{
    public class Order
    {
        public DateTime Momento {get; set;}
        public OrderStatus OrderStatus {get; set;}

        public Order()
        {
            OrderStatus = new OrderStatus();
        }

        // public Order(DateTime momento, OrderStatus orderStatus)
        // {
        //     Momento = momento;
        //     OrderStatus = new OrderStatus(pending)       
        // }
        
    }
}