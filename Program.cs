namespace classes
{
    class Program
    {

        static void Main(string[] args)
        {
            //var customer = new Customer(1);
            //customer.orders.Add(new Order());
            //Console.WriteLine(customer.orders.Count());

            var person = new Person(new DateTime(1999, 1, 1));
            Console.WriteLine("AGE is: {0} ", person.age);

            var cookie = new HttpCookie();
            cookie["name"] = "Lp";
            Console.WriteLine(cookie["name"]);
        }

        static void UseParse()
        {
            var result = int.TryParse("99", out int number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("conversion failed");

        }

        static void UseParams()
        {
            var calc = new Calculator();
            Console.WriteLine(calc.Add(1, 2, 3, 4, 5, 50));
        }

        static void UsePoints()
        {
            try
            {
                //var person = Person.Parse("lp");
                //person.Introduce("noor");

                //var customer = new Customer(1,"lp");
                //Console.WriteLine(customer.id);
                //Console.WriteLine(customer.name);

                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                point.Move(100, 200);
                Console.WriteLine("Pint is at ({0},{1})", point.x, point.y);

            }
            catch (Exception)
            {
                Console.WriteLine("Unexpected error occurred");
            }

        }
    }
}