using System;


namespace HelloWorld
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(createMessage());

            Console.Read();
        }

        public static string createMessage()
        {
            return "Hello World!!!";
        }
    }
}
