using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Test_Taste_Console_Application.Domain.DataTransferObjects;

namespace Test_Taste_Console_Application.Domain.Objects
{
    public class Planet
    {
        public string Id { get; set; }
        public float SemiMajorAxis { get; set; }
        public ICollection<Moon> Moons { get; set; }

        private float averageMoonGravity;

        /// <summary>
        /// BugFix-2: Modified this property due to not proper declaration
        /// </summary>
        public float AverageMoonGravity
        {
            get
            {
                return this.averageMoonGravity;
            }
            set
            {
                this.averageMoonGravity = value;
            }
        }

        public Planet(PlanetDto planetDto)
        {
            Id = planetDto.Id;
            SemiMajorAxis = planetDto.SemiMajorAxis;
            Moons = new Collection<Moon>();
            if(planetDto.Moons != null)
            {
                foreach (MoonDto moonDto in planetDto.Moons)
                {
                    Moons.Add(new Moon(moonDto));
                }

                //BugFix-3: Here, Calculate the average of moon.
                AverageMoonGravity = Moons.Select(data => data.Gravity).Average();
            }
        }

        public Boolean HasMoons()
        {
            return (Moons != null && Moons.Count > 0);
        }
    }
}
