using System;
using System.Collections.Generic;

namespace InterfaceZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Pigeon p = new Pigeon();
            Seagull s = new Seagull();

            List<IFlying> birds = new List<IFlying>() { p, s };
        }
    }
}
