using System.Transactions;


namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj długość pierwszego boku");
            double bok1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj długość drugiego boku");
            double bok2 = double.Parse(Console.ReadLine());

            double diagonal = Math.Sqrt( Math.Pow(bok1,2) + Math.Pow(bok2, 2));
            Console.WriteLine("Przekątna prostokąta ma miarę : " + diagonal);

        }
    }
}