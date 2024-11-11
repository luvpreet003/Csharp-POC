namespace classes
{
    public class Customer
    {
        public int id;
        public string? name;
        public List<Order> orders;

        public Customer(int id) : this()
        {
            this.id = id;
        }

        public Customer(int id, string name): this()
        {
            this.id = id;
            this.name = name;   
        }

        public Customer()
        {
            orders = new List<Order>();
        }

        public void Promote()
        {

        }
    }
}