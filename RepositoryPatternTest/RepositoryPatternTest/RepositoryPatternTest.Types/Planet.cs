using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryPatternTest.Types
{
    public class Planet
    {
        public int PlanetId;
        public string Name;
        public bool IsTerraform;

        public Planet()
        {
        }

        public Planet(int planetId, string name, bool isTerraform)
        {
            PlanetId = planetId;
            Name = name;
            IsTerraform = isTerraform;
        }
    }
}
