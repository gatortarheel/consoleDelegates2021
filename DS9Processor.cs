using System;
using System.Collections.Generic;
using System.Text;

namespace consoleDelegates2021
{
    public static class DS9Processor
    {
        public static void PrintNameAndClassicationOfShip(Spaceship ship)
        {
            Console.WriteLine($"{ship.Name} : {ship.Classification} : {ship.BaryonCount}");
        }

        public static void CalculatePriorityOfShip(Spaceship ship)
        {
            Console.WriteLine($"{ship.Name} : {ship.Classification} : {ship.BaryonCount}");
        }

        public static void BaryonSweep(Spaceship ship)
        {
            ship.BaryonCount = 0;
            Console.WriteLine($"{ship.Name} : {ship.Classification} has been cleared of all Baryon particles.");
        }

        public static void Dock(Spaceship ship)
        {
            var SpaceshipProcessor = new SpaceshipProcessor(ship);
            SpaceshipProcessor.ProcessSpaceship(PrintNameAndClassicationOfShip);
            SpaceshipProcessor.ProcessSpaceship(BaryonSweep);
            SpaceshipProcessor.ProcessSpaceship(PrintNameAndClassicationOfShip);
        }
    }

    public delegate void SpaceshipCallback(Spaceship ship);
    public class SpaceshipProcessor
    {
        Spaceship spaceship { get; set; }
        public SpaceshipProcessor(Spaceship ship)
        {
            spaceship = ship;
        }

        public SpaceshipProcessor()
        { }

        public void ProcessSpaceship(SpaceshipCallback processShip)
        {
            processShip(spaceship);
        }
    }

    public static class DS9DockingPolicyDelegates
    {
        public static decimal ConstitutionClass(Spaceship ship)
        {
            if (ship.Classification == ShipClassification.Constitution)
                return 1000;

            return 0;
        }
        public static decimal HighCrewCapacity(Spaceship ship)
        {
            if (ship.CrewCapacity > 100)
                return ship.CrewCapacity;

            return 0;
        }
        public static decimal TVShow(Spaceship ship)
        {
            if (ship.IsFeaturedOnTvShow)
                return 500;

            return 0;
        }
        //public static ShipPriority CreatePriority(params DiscountPolicy[] policies)
        //{
        //    return order => policies.Max(policy => policy.Invoke(order));
        //}

        //public static PriorityPolicy AssignPriorityToApproachingShips()
        //{
        //    DiscountPolicy best = AssignPriority(
        //        ConstitutionClass,
        //        HighCrewCapacity,
        //        TVShow);
        //    return best;
        //}
    }
}
