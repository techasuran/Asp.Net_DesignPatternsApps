using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RepositoryPatternTest.Repository.Interfaces;
using RepositoryPatternTest.Types;

namespace RepositoryPatternTest.Repository.Repositories
{
    public class OracleRepository : IPlanetRepository
    {
        #region IPlanetRepository Members

        public List<Planet> GetPlanets()
        {
            // Simulate returning the list of data from the database.
            List<Planet> planetList = new List<Planet>();

            // OracleConnection code would actually go here, this is to keep things simple.
            planetList.Add(new Planet(1, "Mercury", false));
            planetList.Add(new Planet(2, "Venus", true));
            planetList.Add(new Planet(3, "Earth", true));
            planetList.Add(new Planet(4, "Mars", true));
            planetList.Add(new Planet(5, "Jupiter", false));
            planetList.Add(new Planet(6, "Saturn", false));
            planetList.Add(new Planet(7, "Uranus", false));
            planetList.Add(new Planet(8, "Neptune", false));
            planetList.Add(new Planet(9, "Pluto", false));
            planetList.Add(new Planet(10, "Planet X", false));

            return planetList;
        }

        public List<Planet> GetStars()
        {
            // Simulate returning the list of data from the database.
            List<Planet> planetList = new List<Planet>();

            // OracleConnection code would actually go here, this is to keep things simple.
            planetList.Add(new Planet(1, "Sun", false));
            planetList.Add(new Planet(2, "Alpha Centauri", false));

            return planetList;
        }

        #endregion
    }
}
