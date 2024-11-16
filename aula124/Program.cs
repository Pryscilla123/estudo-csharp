<<<<<<< HEAD
﻿using aula124.Entities;
using aula124.Entities.Enums;

namespace aula124;

class Program
{
    static void Main(string[] args)
    {
        Order order = new Order(){
            Id = 1080,
            Moment = DateTime.Now,
            Status = OrderStatus.Delivered
        };

        System.Console.WriteLine(order);
        System.Console.WriteLine(order.Status);

        string txt = OrderStatus.PendingPayment.ToString();
        OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

        System.Console.WriteLine(txt);
        System.Console.WriteLine(os);
    }
}
=======
﻿using aula124.Entities;
using aula124.Entities.Enums;

namespace aula124;

class Program
{
    static void Main(string[] args)
    {
        Order order = new Order(){
            Id = 1080,
            Moment = DateTime.Now,
            Status = OrderStatus.Delivered
        };

        System.Console.WriteLine(order);
        System.Console.WriteLine(order.Status);

        string txt = OrderStatus.PendingPayment.ToString();
        OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

        System.Console.WriteLine(txt);
        System.Console.WriteLine(os);
    }
}
>>>>>>> 2f54776591db587008f28ed6e6b0c338db6e9ded
