namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj swoje dane.");
            
            Console.WriteLine("Podaj imię :");
            string name = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko :");
            string surname = Console.ReadLine();

            Console.WriteLine("Podaj numer telefonu :");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("Podaj mail :");
            string  email = Console.ReadLine();

            Console.WriteLine("Podaj wzrost :");
            double high = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wagę :");
            double weigh = double.Parse(Console.ReadLine());
           

            Console.Write("Imie : ");
            Console.WriteLine(name);
            Console.Write("Nazwisko : ");
            Console.WriteLine(surname);
            Console.Write("Numer telefonu : ");
            Console.WriteLine(phoneNumber);
            Console.Write("Mail : ");
            Console.WriteLine(email);
            Console.Write("Wzrost : ");
            Console.WriteLine(high);
            Console.Write("Waga : ");
            Console.WriteLine(weigh);
        }
    }
}