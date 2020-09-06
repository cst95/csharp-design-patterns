using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var singletonOne = Singleton.Instance;
            var singletonTwo = Singleton.Instance;

            Console.WriteLine(singletonOne.Id);
            Console.WriteLine(singletonTwo.Id);
        }
    }
}