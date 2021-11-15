using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Station_de_ski
{
    class Displayer
    {
        /// <summary>
        /// Display every occurence of canton one time
        /// </summary>
        /// <param name="skiStations">IEnumerable of SkiStation : the collection of all ski station</param>
        public static void AllCanton(IEnumerable<SkiStation> skiStations)
        {
            string str = "";

           IEnumerable<string> cantons = skiStations
                .Where(skiStation => skiStation.Canton.Length > 0)
                .Select(skiStation => skiStation.Canton)
                .Distinct();

            foreach (string canton in cantons)
            {
                str += canton + "\n";
            }

            Console.WriteLine(str);

        }

        /// <summary>
        /// Display <paramref name="skiStations"/> order by canton then by name 
        /// </summary>
        /// <param name="skiStations">IEnumerable of SkiStation : the collection of all ski station</param>
        public static void OrderByCanton(IEnumerable<SkiStation> skiStations)
        {
            string str = "";

            IEnumerable<SkiStation> skiStationsCantonOrdered = skiStations
                .OrderBy(skiStation => skiStation.Canton)
                .ThenBy(skiStation => skiStation.Name);

            foreach (SkiStation skiStation in skiStationsCantonOrdered)
            {
                str += skiStation.ToString() + "\n";
            }

            Console.WriteLine(str);
        }

        /// <summary>
        /// Display <paramref name="skiStations"/> where the price for the group don't exceed the <paramref name="price"/>
        /// </summary>
        /// <param name="skiStations">IEnumerable of SkiStation : the collection of all ski station</param>
        /// <param name="numberOfChild">int : number of child</param>
        /// <param name="numberOfAdult">int : number of adult</param>
        /// <param name="price">int : the max price, not included</param>
        public static void FilterByPrice(IEnumerable<SkiStation> skiStations, int numberOfChild, int numberOfAdult, int price)
        {
            string str = "";

            IEnumerable<SkiStation> skiStationsFilterByPrice = skiStations
                .Where(skiStation => skiStation.ChildRate * numberOfChild + skiStation.AdultRate * numberOfAdult < price);

            foreach (SkiStation skiStation in skiStationsFilterByPrice)
            {
                str += skiStation.ToString() + "\n";
            }

            Console.WriteLine(str);
        }
    }
}
