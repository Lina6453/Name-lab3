using Sistem;

namespace Name2
{
    public class Person
    {
        private int p;
        string name;
        const double k = 1.5;
        string age;
        public Person (string nm)
        {
            name = nm;
        }
        public string GetName()
        {
            return name;
        }
        public Person (string ag)
        {
            age = ag;
        }
        public string GetAge()
        {
            return age;
        }
        public int Dohod(int p)
        {
            return Convert.ToInt32(Math.Abs(p * k));
        }
        public MaxDohod (int p)
        {
            return Convert.ToInt32(Math.Abs(p * o));
        }
    }
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Введите имя");
            string k = Console.ReadLine();
            Console.WriteLine("Введите Минимальный доход");
            string u  = Console.ReadLine();
            int f = Convert.ToInt32(u);
            Console.WriteLine("Введите возраст");
            string s = Console.ReadLine;
            Person q = new Person(k);
            Console.WriteLine( "Имя=  " + q.GetName());
            Person n = new Person(u);
            Console.WriteLine("Доход=  " + n.Dohod(f).ToString());
            Person t = new Person(u);
            Console.WriteLine("МаксДоход = " + t.MaxDohod(f).ToString());
            Console.ReadKey();
        }
    }
}