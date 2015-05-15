using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RepositoryPatternTest.Repository.Interfaces;
using RepositoryPatternTest.Types;

namespace RepositoryPatternTest.Repository.Repositories
{
    public class MSSQLPlanetRepository : IPlanetRepository
    {
        #region IPlanetRepository Members

        public List<Planet> GetPlanets()
        {
            // Simulate returning the list of data from the database.
            List<Planet> planetList = new List<Planet>();

            // SqlConnection code would actually go here, this is to keep things simple.
            planetList.Add(new Planet(1, "Mercury", false));
            planetList.Add(new Planet(2, "Venus", true));
            planetList.Add(new Planet(3, "Earth", true));
            planetList.Add(new Planet(4, "Mars", true));
            planetList.Add(new Planet(5, "Jupiter", false));
            planetList.Add(new Planet(6, "Saturn", false));
            planetList.Add(new Planet(7, "Uranus", false));
            planetList.Add(new Planet(8, "Neptune", false));
            planetList.Add(new Planet(9, "Pluto", false));

            return planetList;
        }

        public List<Planet> GetStars()
        {
            // Simulate returning the list of data from the database.
            List<Planet> planetList = new List<Planet>();

            // SqlConnection code would actually go here, this is to keep things simple.
            planetList.Add(new Planet(1, "Sun", false));

            return planetList;
        }

        #endregion
    }
}
