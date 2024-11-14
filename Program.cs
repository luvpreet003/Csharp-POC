using System.Runtime.CompilerServices;

namespace classes
{
    class Program
    {

        static void Main(string[] args)
        {
            Post post = new Post();
            Console.WriteLine("Create a Post!");

            while (true)
            {
                Console.WriteLine("Write commands below!");

                var command = Console.ReadLine().ToUpper();
                if (command == "NEW")
                {
                    Console.WriteLine("Title:");
                    var title = Console.ReadLine();
                    Console.WriteLine("Description: ");
                    var description = Console.ReadLine();
                    post.CreatePost(title, description);
                }
                else if (command == "SHOW")
                {
                    Post result = post.ShowPost();
                    Console.WriteLine("Title: {0}, Description: {1}, Vote: {2}, Date created: {3}", result._title, result._description, result._vote, result._dateCreated);
                }
                else if (command == "UPVOTE")
                {
                    post.UpVote();
                }
                else if (command == "DOWNVOTE")
                {
                    post.DownVote();
                }
                else if (command == "DELETE")
                {
                    post.DeletePost();
                }
                else
                {
                    Console.WriteLine("Invalid command");
                }
            }
        }
        static void UseStopwatch()
        {
            StopWatch watch = new StopWatch();
            Console.WriteLine("STOPWATCH");

            while (true)
            {
                Console.WriteLine("Type start/stop to play!");
                var command = Console.ReadLine().ToUpper();

                if (command == "START")
                {
                    watch.Start();

                }
                else if (command == "STOP")
                {
                    var duration = watch.Stop();
                    if (duration != TimeSpan.Zero)
                    {
                        Console.WriteLine("The watch ran for {0} seconds", duration.TotalSeconds);
                    }
                }
                else if (command == "EXIT")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid command try again!");
                }
            }
        }

        static void UseParse()
        {
            var result = int.TryParse("99", out int number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("conversion failed");

            //var customer = new Customer(1);
            //customer.orders.Add(new Order());
            //Console.WriteLine(customer.orders.Count());

            //var person = new Person(new DateTime(1999, 1, 1));
            //Console.WriteLine("AGE is: {0} ", person.age);

            //var cookie = new HttpCookie();
            //cookie["name"] = "Lp";
            //Console.WriteLine(cookie["name"]);

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