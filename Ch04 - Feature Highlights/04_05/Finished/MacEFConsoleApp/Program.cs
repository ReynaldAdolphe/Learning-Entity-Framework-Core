using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoConsole.Entities;

namespace MacEFConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
                        using (var db = new ActorDbContext())
            {
                // Seed
                db.Actors.AddRange(new Actor { Name= "Bruce Lee", Age=77, AcademyWinner = false},
                                   new Actor { Name = "Alec Baldwin", Age = 55, AcademyWinner = false });

                var count = db.SaveChanges();

                // Fetch & Write out data
                Console.WriteLine("{0} additional records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All Actors now in database:");
                foreach (var Actor in db.Actors)
                {
                    Console.WriteLine($"Name - {Actor.Name},\t\t" + 
                                      $"Age: {Actor.Age},\t\t" +
                                      $"Academy Winner: {Actor.AcademyWinner}");
                }

                Console.ReadLine();
            }
        }
    }
}
