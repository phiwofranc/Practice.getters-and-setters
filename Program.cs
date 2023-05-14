using System.Net.NetworkInformation;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie Shrek = new Movie("Shrek", "Adam Adamson", "PG");
            avengers.Rating = "dog";
            Console.WriteLine(avengers.Rating);
        }
    }
}