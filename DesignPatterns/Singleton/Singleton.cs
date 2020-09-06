using System;

namespace Singleton
{
    public class Singleton
    {
        private static readonly Lazy<Singleton> _instance = new Lazy<Singleton>(() => new Singleton());
        
        private Singleton()
        {
            Console.WriteLine("Create database we only want to initialise once...");
        }

        public static Singleton Instance => _instance.Value;
        public Guid Id { get; } = Guid.NewGuid();
    }
}