namespace classes
{
    public class Person
    {
        public string? name;

        public DateTime birthDate { get; private set; }

        public int age
        {
            get 
            { 
                var timeSpan = DateTime.Today - birthDate;
                var years = timeSpan.Days / 365;
                return years;
            }

        }       

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}",to,name);
        }

        public static Person Parse(string str)
        {
            return new Person
            {
                name = str
            };
        }

        public Person()
        {

        }

        public Person(DateTime birth)
        {
            birthDate = birth;
        }
    }
}