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

        private static Bacon FryBaconAsync(int slices)
        {
            throw new NotImplementedException();
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
