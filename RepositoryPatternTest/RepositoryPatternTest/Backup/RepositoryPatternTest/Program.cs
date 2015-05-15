using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Reflection;
using RepositoryPatternTest.Business;
using RepositoryPatternTest.Types;
using RepositoryPatternTest.Repository.Interfaces;
using RepositoryPatternTest.Repository.Repositories;

namespace RepositoryPatternTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load planets from the MSSQL repository.
            PlanetBusiness planetBusiness = new PlanetBusiness(new MSSQLPlanetRepository());            
            TestPlanets(planetBusiness);

            // Load planets from the Oracle repository.
            planetBusiness = new PlanetBusiness(new OracleRepository());
            TestPlanets(planetBusiness);

            // Load planets from the Test repository.
            planetBusiness = new PlanetBusiness(new TestRepository());
            TestPlanets(planetBusiness);

            // Load planets from the default repository as specified in the web.config. Allows for changing the repository at run-time, without changing code!
            Type obj = Type.GetType(ConfigurationManager.AppSettings["DefaultRepository"]);
            ConstructorInfo constructor = obj.GetConstructor(new Type[] { });
            IPlanetRepository defaultRepository = (IPlanetRepository)constructor.Invoke(null);

            planetBusiness = new PlanetBusiness(defaultRepository);
            TestPlanets(planetBusiness);

            Console.ReadKey();
        }

        private static void TestPlanets(PlanetBusiness planetBusiness)
        {
            // Basic driver class to test our planet business class and display output.
            Console.WriteLine();
            Console.WriteLine("Planets:");
            Console.WriteLine();

            List<Planet> planetList = planetBusiness.GetPlanets();
            foreach (Planet planet in planetList)
            {
                Console.WriteLine(planet.PlanetId + ". " + planet.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Terraformable Planets:");
            Console.WriteLine();

            planetList = planetBusiness.GetTerraformPlanets();
            foreach (Planet planet in planetList)
            {
                Console.WriteLine(planet.PlanetId + ". " + planet.Name);
            }
        }
    }
}
