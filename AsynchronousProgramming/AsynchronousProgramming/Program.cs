using System;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffee coffee = PourCoffe();
            Console.WriteLine("Coffee Is Ready");

            var egg = FryEggAsync(2);
            var bacon = FryBaconAsync(2);
        }

        private static async Task<Bacon> FryBaconAsync(int slices)
        {
            Console.WriteLine($"Putting {slices} of bacon on the pan...");
            Console.WriteLine("Cooking first side of bacon");
            await Task.Delay(3000);
            for(int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of a bacon");
            }
            Console.WriteLine("Cooking second side of bacon");
            await Task.Delay(3000);
            Console.WriteLine("Bacons are ready");

            return new Bacon();
        }

        private static async Task<Egg> FryEggAsync(int numnberOfEgg)
        {
            Console.WriteLine("Warming the egg pan...");
            await Task.Delay(5000);
            Console.WriteLine($"Cracking {numnberOfEgg} eggs");
            Console.WriteLine("Started cooking eggs");
            await Task.Delay(5000);
            Console.WriteLine("Eggs are ready..");

            return new Egg();
        }

        private static Coffee PourCoffe()
        {
            Console.WriteLine("Coffee Is Pouring");

            return new Coffee();
        }
    }

    internal class Bacon
    {
    }

    internal class Egg
    {
    }

    internal class Coffee
    {
    }
}
