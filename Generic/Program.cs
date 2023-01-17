namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Generics Number = new Generics();
            int MaximumNumber = Number.data(22, 44, 90);
            Console.WriteLine("Maximum Integer is " + MaximumNumber);
        }
    }
}