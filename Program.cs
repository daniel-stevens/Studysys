using System;
namespace studentmanagementsys

{
    public class Program
    {
        static void Main(string[] args)
        {

            User daniel = new User("Danieluser", "Daniel Stevens", 1);
            Console.WriteLine(daniel.Username);
            Console.WriteLine("Hello World!");
        }
    }
}
