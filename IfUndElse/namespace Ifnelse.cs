namespace IfUndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int i = 5;
            if (i == 5)
            {
                Console.WriteLine("Number on 5");
            }
            else
            {
                if (i == 8)
                {
                    Console.WriteLine("Number on midagi muud");
                }
                else
                {
                    Console.WriteLine("Midagi on täitsa katki");
                }
            }

        }
    }
}
