using System;

namespace Section2Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Stopwatch program.");
                Console.WriteLine("Choice: 1 - To Start | 2 - To Stop Watch");
                var option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    var stopwatch = new Stopwatch();
                    stopwatch.Start();
                    
                    Console.WriteLine(stopwatch.Stop());
                }

                if (option == 2)
                    break;
                
            } while (true);
        }
    }
}
