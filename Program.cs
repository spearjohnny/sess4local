using System;

namespace sess4local
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TITLE: Age calculator on different planets");

            string [] spacePlanets = {"Venus","Mars","Jupiter","Neptune"};
            double [] orbitalPeriod = {0.61519724D,1.8808158D,11.8626615D,164.79132D};

             int earthAge = 31557600, spaceAge = 631154000;

            double ageInEarth = spaceAge/earthAge;    
            for (int i = 0; i < spacePlanet.Length; i++)
            {
                double ageInPlanets = ageInEarth/orbitalPeriod[i];        
                Console.WriteLine("Earth age:" +earth_age+ "Earth-years old- " +spacePlanets[i]+":"+ageInPlanets+" Earth-years old");
        }
    }
}
