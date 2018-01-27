namespace Template
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Cloud c = new Azure();
            c.DoWork();

            Console.ReadKey();
        }
    }
}
