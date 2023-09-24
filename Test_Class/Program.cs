using System.Diagnostics.Contracts;
using System.Runtime.Intrinsics.X86;

namespace Test_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Customer(1, "A");
            c1.AddToOrder(10);
            c1.AddToOrder(20);

            Console.WriteLine($"Customer {c1.Name} (ID:{c1.ID}) order count is {c1.Orders.Count()}");
            Console.WriteLine($"Orders are:");
            foreach (var order in c1.Orders){
                Console.WriteLine(order.OrderID);
            }

            // var c2 = new Customer(2, "B");


        }
    }
}