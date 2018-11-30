using DemoConsole.Entities;
using System;

namespace DemoConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new ActorDbContext())
            {                
                Console.WriteLine($"Type mapper in use: ");
                Console.WriteLine($"Mapping for bool:  ");
                Console.WriteLine($"Mapping for string:  ");

                Console.ReadLine();
            }
        }
    }
}
