using System;
using System.Collections.Generic;

namespace consoleDelegates2021
{
    public class SpaceshipData
    {
        public List<Spaceship> Spaceships { get; set; }

        public SpaceshipData()
        {
            Spaceships = new List<Spaceship>
            {
                new Spaceship
                {
                    Id = new Guid("58498ed1-35d1-4593-9464-aa2db0550d6f"),
                    Classification = ShipClassification.Constitution,
                    Designation = "NCC1701",
                    Name  = "USS Enterprise",
                    CrewCapacity = 500,
                    PassengerCapacity = 100,
                    BaryonCount = 10000,
                    CommissionedDate = new DateTime(2260,01,01),
                    IsFeaturedOnTvShow = true,
                },
                new Spaceship
                {
                    Id = new Guid("40e22b0d-dc4a-4f45-9bee-fd5b9f43b6bc"),
                    Classification = ShipClassification.Constitution,
                    Designation = "NCC1701A",
                    Name  = "USS Enterprise A",
                    CrewCapacity = 600,
                    PassengerCapacity = 125,
                    BaryonCount = 10000,
                    CommissionedDate = new DateTime(2270,01,01),
                                        IsFeaturedOnTvShow = true,
                },
                new Spaceship
                {
                    Id = new Guid("1cc474b2-6805-4139-868a-ae0662dba025"),
                    Classification = ShipClassification.Excelsior,
                    Designation = "NCC1701A",
                    Name  = "USS Enterprise B",
                    CrewCapacity = 600,
                    PassengerCapacity = 125,
                    BaryonCount = 10000,
                    CommissionedDate = new DateTime(2290,01,01),
                                        IsFeaturedOnTvShow = false,
                },
                new Spaceship
                {
                    Id = new Guid("f74544f8-51e3-4f25-8ce8-878b1c68174d"),
                    Classification = ShipClassification.Excelsior,
                    Designation = "NCC1701C",
                    Name  = "USS Enterprise C",
                    CrewCapacity = 700,
                    PassengerCapacity = 150,
                    BaryonCount = 10000,
                    CommissionedDate = new DateTime(2300,01,01),
                                        IsFeaturedOnTvShow = false,
                },
                new Spaceship
                {
                    Id = new Guid("1fa8275b-4ad7-4851-b8b3-44448fb06b0a"),
                    Classification = ShipClassification.Galaxy,
                    Designation = "NCC1701D",
                    Name  = "USS Enterprise D",
                    CrewCapacity = 800,
                    PassengerCapacity = 200,
                    BaryonCount = 10000,
                    CommissionedDate = new DateTime(2400,01,01),
                                        IsFeaturedOnTvShow = true,
                },
                new Spaceship
                {
                    Id = new Guid("0f6723ea-416e-4d09-93fd-fbaf268cdc01"),
                    Classification = ShipClassification.Sovereign,
                    Designation = "NCC1701E",
                    Name  = "USS Enterprise E",
                    CrewCapacity = 700,
                    PassengerCapacity = 150,
                    BaryonCount = 10000,
                    CommissionedDate = new DateTime(2410,01,01),
                                        IsFeaturedOnTvShow = false,
                },
                new Spaceship
                {
                    Id = new Guid("745f6c84-b0ea-41ab-a034-af85c8374ffc"),
                    Classification = ShipClassification.Crossfield,
                    Designation = "NCC1301",
                    Name  = "USS Discovery",
                    CrewCapacity = 500,
                    PassengerCapacity = 50,
                    BaryonCount = 10000,
                    CommissionedDate = new DateTime(2240,01,01),
                                        IsFeaturedOnTvShow = true,
                },
                new Spaceship
                {
                    Id = new Guid("73389722-91e3-45cd-8a56-e14b73abd258"),
                    Classification = ShipClassification.Defiant,
                    Designation = "NX-74205",
                    Name  = "ISS Defiant",
                    CrewCapacity = 10,
                    PassengerCapacity = 5,
                    BaryonCount = 10000,
                    CommissionedDate = new DateTime(2400,01,01),
                                        IsFeaturedOnTvShow = true,
                }
            };
        }
    }
}
