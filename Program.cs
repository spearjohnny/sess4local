namespace sess4local
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TITLE: Age calculator on different planets");
            int earthAge = 31557600, spaceAge = 631154000;
            string [] spacePlanets = {"Venus","Mars","Jupiter","Neptune"};
            double [] orbitalPeriod = {0.61519724D,1.8808158D,11.8626615D,164.79132D}, ageInEarth = spaceAge/earthAge;  
            for (int i = 0; i < spacePlanet.Length; i++)
            {
                double ageInPlanets = ageInEarth/orbitalPeriod[i];        
                System.Console.WriteLine("Earth age:" +ageInEarth+ "Earth-years old- " +spacePlanets[i]+":"+ageInPlanets+" Earth-years old");
        }
    }
}
