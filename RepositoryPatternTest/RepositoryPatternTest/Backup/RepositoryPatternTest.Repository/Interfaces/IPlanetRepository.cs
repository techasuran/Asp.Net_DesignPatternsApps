using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RepositoryPatternTest.Types;

namespace RepositoryPatternTest.Repository.Interfaces
{
    public interface IPlanetRepository
    {
        List<Planet> GetPlanets();
        List<Planet> GetStars();
    }
}
