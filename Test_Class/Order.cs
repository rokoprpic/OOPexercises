namespace Test_Class
{
    public class Order
    {
        public int OrderID {  get; private set; }
        public Order(int orderID)
        {
            this.OrderID = orderID;
        }
    }
}