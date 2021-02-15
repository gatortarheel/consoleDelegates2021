using System;
using System.Collections.Generic;

namespace consoleDelegates2021
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("DS9 Ship Delegate Example");
            SpaceshipData spaceshipData = new SpaceshipData();
            var spaceships = spaceshipData.Spaceships;

            foreach (var ship in spaceships)
            {
                DS9Processor.Dock(ship);
            }
        }

    }
}
