using System;
using System.Collections.Generic;
using System.Text;
using static consoleDelegates2021.Program;

namespace consoleDelegates2021
{
    public class Spaceship
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ShipClassification Classification { get; set; }

        public string Designation { get; set; }

        public int CrewCapacity { get; set; }

        public int PassengerCapacity { get; set; }

        public int TotalCapacity { get { return CrewCapacity + PassengerCapacity; } }

        public bool? HasWarp { get; set; }

        public const string AdmiralOfFleet = "Shane of course";

        public DateTime CommissionedDate { get; set; }

        public DateTime? DecommissionedDate { get; set; }

        public bool IsFeaturedOnTvShow { get; set; }

        public int BaryonCount { get; set; }

        //// Call a passed-in delegate on each paperback book to process it:
        ///*public void ProcessPaperbackBooks(ProcessBookCallback processBook)
        //{
        //    foreach (Book b in list)
        //    {
        //        if (b.Paperback)
        //            // Calling the delegate:
        //            processBook(b);
        //    }
        //}*/

        //List<Spaceship> Spaceships = new List<Spaceship>();
        //// Call a passed-in delegate on each paperback book to process it:
        //public void AssignPriority(PriorityPolicyCallback processShip)
        //{
        //    foreach (var ship in Spaceships)
        //    {
        //        if (ship.IsFeaturedOnTvShow)
        //            // Calling the delegate:
        //            processShip(ship);
        //    }
        //}
    }
}
