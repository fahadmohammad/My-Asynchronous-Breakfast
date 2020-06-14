using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Coffee coffee = PourCoffe();
            Console.WriteLine("Coffee Is Ready");

            var eggTask = FryEggAsync(2);           
            var baconTask = FryBaconAsync(2);           
            var toastWithButterAndJamTask = MakeToastWithButterAndJamAsync(2);         

            var egg = await eggTask;
            Console.WriteLine("eggs are ready");
            var bacon = await baconTask;
            Console.WriteLine("bacon is ready");
            var toast = await toastWithButterAndJamTask;
            Console.WriteLine("toast is ready");


            //    var breakfastTasks = new List<Task> { egg, bacon, toastWithButterAndJam };

            //    while(breakfastTasks.Count > 0)
            //    {
            //        Task finishedTask = Task.WhenAny(breakfastTasks);

            //        if (finishedTask == egg)
            //        {
            //            Console.WriteLine("eggs are ready");
            //        }
            //        else if (finishedTask == bacon)
            //        {
            //            Console.WriteLine("bacon is ready");
            //        }
            //        else if (finishedTask == toastWithButterAndJam)
            //        {
            //            Console.WriteLine("toast is ready");
            //        }
            //        breakfastTasks.Remove(finishedTask);
            //    }

            var juice = PourOJ();
            Console.WriteLine("juice is ready");
            Console.WriteLine("------>>>>> Whoooo!!!!!!Breakfast is ready!----------->>>>>>>");

        }

        private static Juice PourOJ()
        {
            Console.WriteLine("Pouring orange juice");

            return new Juice();
        }

        private static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
        {
            var toast = await ToastBreadAsync(number);
            ApplyButter(toast);
            ApplyJam(toast);
            var end = Task.CompletedTask;
            return new Toast();
        }

        private static void ApplyJam(Toast toast) => 
            Console.WriteLine("Applying Jam....");


        private static void ApplyButter(Toast toast) => 
            Console.WriteLine("Applying Butter...");
        

        private static async Task<Toast> ToastBreadAsync(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }
            Console.WriteLine("Start toasting...");
            await Task.Delay(3000);
            Console.WriteLine("Remove toast from toaster");

            var end = Task.CompletedTask;

            return new Toast();
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
            Console.WriteLine("Bacons put to the plate");

            var end = Task.CompletedTask;

            return new Bacon();
        }

        private static async Task<Egg> FryEggAsync(int numnberOfEgg)
        {
            Console.WriteLine("Warming the egg pan...");
            await Task.Delay(5000);
            Console.WriteLine($"Cracking {numnberOfEgg} eggs");
            Console.WriteLine("Started cooking eggs");
            await Task.Delay(5000);
            Console.WriteLine("Eggs put to the plate..");

            var end = Task.CompletedTask;

            return new Egg();
        }

        private static Coffee PourCoffe()
        {
            Console.WriteLine("Coffee Is Pouring");

            return new Coffee();
        }
    }

    internal class Juice
    {
    }

    internal class Toast
    {
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
