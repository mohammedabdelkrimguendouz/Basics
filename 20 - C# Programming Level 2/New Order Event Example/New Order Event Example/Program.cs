using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Order_Event_Example
{
    // Publisher Subscriber Design Pattern
    public class OrderEventArgs:EventArgs
    {
        public int OrderID { get; }
        public float OrderToatlPrice { get; }
        public string ClientEmail { get; }

        public OrderEventArgs(int orderID, float orderToatlPrice, string clientEmail)
        {
            OrderID = orderID;
            OrderToatlPrice = orderToatlPrice;
            ClientEmail = clientEmail;
        }
    }
    public class Order
    {
        public event EventHandler<OrderEventArgs> OnOrderCreated;
        public void Create(int orderID, float orderToatlPrice, string clientEmail)
        {
            Console.WriteLine("\n\nnew order created .");
            if(OnOrderCreated!=null)
                OnOrderCreated(this,new OrderEventArgs(orderID, orderToatlPrice, clientEmail));
        }
    }

    public class EmailService
    {
        public void Subscribe(Order order)
        {
            order.OnOrderCreated += HandleNewOrder;
        }
        public void UnSubscribe(Order order)
        {
            order.OnOrderCreated -= HandleNewOrder;
        }
        public void HandleNewOrder(object sender,OrderEventArgs e)
        {
            Console.WriteLine($"\n-------------------Email Service-------------");
            Console.WriteLine($"Order ID = {e.OrderID}");
            Console.WriteLine($"Total Price ID = {e.OrderToatlPrice}");
            Console.WriteLine($"Email ID = {e.ClientEmail}");
            Console.WriteLine($"\nSend An Email");
            Console.WriteLine($"\n---------------------------------------------");
        }
    }
    public class SMSService
    {
        public void Subscribe(Order order)
        {
            order.OnOrderCreated += HandleNewOrder;
        }
        public void UnSubscribe(Order order)
        {
            order.OnOrderCreated -= HandleNewOrder;
        }
        public void HandleNewOrder(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"\n-------------------SMS Service-------------");
            Console.WriteLine($"Order ID = {e.OrderID}");
            Console.WriteLine($"Total Price ID = {e.OrderToatlPrice}");
            Console.WriteLine($"Email ID = {e.ClientEmail}");
            Console.WriteLine($"\nSend  SMS");
            Console.WriteLine($"\n-------------------------------------------");
        }
    }
    public class ShippingService
    {
        public void Subscribe(Order order)
        {
            order.OnOrderCreated += HandleNewOrder;
        }
        public void UnSubscribe(Order order)
        {
            order.OnOrderCreated -= HandleNewOrder;
        }
        public void HandleNewOrder(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"\n-------------------Shipping Service-------------");
            Console.WriteLine($"Order ID = {e.OrderID}");
            Console.WriteLine($"Total Price ID = {e.OrderToatlPrice}");
            Console.WriteLine($"Email ID = {e.ClientEmail}");
            Console.WriteLine($"\nHandle Shipping");
            Console.WriteLine($"\n------------------------------------------------");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            EmailService emailService = new EmailService();
            SMSService smsService = new SMSService();
            ShippingService shippingService = new ShippingService();

            emailService.Subscribe(order);
            smsService.Subscribe(order);
            shippingService.Subscribe(order);
            shippingService.UnSubscribe(order);

            order.Create(1, 540, "koko@gmail.com");

            //order.Create(2, 390, "ali@gmail.com");

            Console.ReadKey();
        }
    }
}
