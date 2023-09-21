namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = "Sławek";
            string surname = "Łach";
            int age = 39;
            char sex = 'm';
            string personalId = "1234567890";
            uint idWorker = 2509324094;

            Console.Write("Imie :");
            Console.WriteLine(name);
            Console.Write("Nazwisko :");
            Console.WriteLine(surname);
            Console.Write("Wiek :");
            Console.WriteLine(age);
            Console.Write("Płeć :");
            Console.WriteLine(sex);
            Console.Write("PESEl :");
            Console.WriteLine(personalId);
            Console.Write("Numer pracownika :");
            Console.WriteLine(idWorker);
        }
    }
}