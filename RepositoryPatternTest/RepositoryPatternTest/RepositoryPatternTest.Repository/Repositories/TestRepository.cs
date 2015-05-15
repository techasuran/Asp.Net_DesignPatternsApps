using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RepositoryPatternTest.Repository.Interfaces;
using RepositoryPatternTest.Types;

namespace RepositoryPatternTest.Repository.Repositories
{
    public class TestRepository : IPlanetRepository
    {
        #region IPlanetRepository Members

        public List<Planet> GetPlanets()
        {
            // Simulate returning the list of data from the database.
            List<Planet> planetList = new List<Planet>();

            planetList.Add(new Planet(1, "Earth", true));
            planetList.Add(new Planet(2, "Test Planet", true));

            return planetList;
        }

        public List<Planet> GetStars()
        {
            // Simulate returning the list of data from the database.
            List<Planet> planetList = new List<Planet>();

            planetList.Add(new Planet(1, "None", false));

            return planetList;
        }

        #endregion
    }
}
