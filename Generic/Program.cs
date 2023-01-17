namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Generics Number = new Generics();
            double MaximumNumber = Number.data(22.30, 44.15, 90.10);
            Console.WriteLine("Maximum Floating Integer is " + MaximumNumber);
        }
    }
}