using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RepositoryPatternTest.Repository.Interfaces;
using RepositoryPatternTest.Types;

namespace RepositoryPatternTest.Business
{
    public class PlanetBusiness
    {
        IPlanetRepository _repository;

        public PlanetBusiness(IPlanetRepository repository)
        {
            _repository = repository;
        }

        public List<Planet> GetPlanets()
        {
            return _repository.GetPlanets();
        }

        public List<Planet> GetStars()
        {
            return _repository.GetStars();
        }

        public List<Planet> GetTerraformPlanets()
        {
            // Return the list of filtered data from the database.
            List<Planet> planetList = _repository.GetPlanets();

            var results = from p in planetList
                          where p.IsTerraform == true
                          select p;

            return results.ToList();
        }
    }
}
