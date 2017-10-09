using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingExperience
{
    class CityValidator
    {
        private readonly string[] _citiesInAmerica;

        public CityValidator(string[] citiesInAmerica)
        {
            _citiesInAmerica = citiesInAmerica;
        }
        public bool IsAmericanCity(string cityToTest)
        {
            var nullableInt = new double?();


            if (string.IsNullOrEmpty(cityToTest)) return false;
            
        }
    }
}
