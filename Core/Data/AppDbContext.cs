using Core.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data
{
    internal class AppDbContext
    {
        List<Country> countries = new List<Country>();
        List<Planet> planet = new List<Planet>();
        private object planets;

        public void CreateCountry(Country country)
        {
            countries.Add(country);

        }
        public void UpdateCountry(Country country)
        {
            foreach (var item in countries)
            {
                Console.WriteLine(item);
            }
        }   
            static void RemoveCountry(Country country)
            {
                Country fcountry = null;
                fcountry = country.GetType(x => x.country == country); 
            }

              public List<Country> GetAllCountries()
              {
                return GetAllCountries();
              }

            public List<Country> GetCountryByRegion(Region region)
            { 
                return GetCountryByRegion(region.Region);
            }

            public void CreatePlanet(Planet planet)
            {
                planets.Add(planet);
            }
            public void UpdatePlanet(Planet planet)
            {
                foreach (var item in planets)
                {
                    Console.WriteLine(item);
                }
            }
        public void RemovePlanet(Planet planet)
        {
            Planet fplanet = null;
            fplanet = planet.Equals(x=>x.Planet == planet);
            planets.Remove(planet);
        }
        public static List <Planet> GetAllPlanets()
        { 
            return GetAllPlanets(); 
        }


    }
}
