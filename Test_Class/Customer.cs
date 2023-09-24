using System.ComponentModel;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Test_Class
{
    public class Customer
    {
        public int? ID { get; private set; }
        public string? Name { get; private set; }

        public readonly List<Order> Orders = new List<Order>();
        public Customer(int id)
        {
            this.ID = id;
        }
        public Customer(int id, string name) : this(id)
        {
            this.Name= name;
        }
        public void AddToOrder(int orderID)
        {
            Orders.Add(new Order(orderID));
        }
    }
}
