using System;
using System.Linq;
using System.Collections.Generic;

namespace Station_de_ski
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<SkiStation> skiStations = Parser.ProcessCSV("SwissSkiDB.csv", ';');

            Displayer.AllCanton(skiStations);
            Displayer.OrderByCanton(skiStations);
            Displayer.FilterByPrice(skiStations, 2, 2, 150);

        }
    }
}
