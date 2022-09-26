using System;

namespace sess10_Namespaces
{
    /// <summary>
    /// Enumeration of various seasons in the year
    /// </summary>
    
    public enum Seasons
    {
        Summer,
        Autumn,
        Winter,
        Spring
    };
    public class DemoSeasons
    {
        static void Main(string[] args)
        {
            var favouriteTime = Seasons.Summer;
            Seasons plantingTime = Seasons.Spring;

            //Display the various times/seasons
            Console.WriteLine($"Time to till the land and plant is: {plantingTime}"
                +$"\nTime to swim and have a cookout BBQ is: {favouriteTime}");
        }
    }
}
