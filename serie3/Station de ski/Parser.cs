using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Station_de_ski
{
    class Parser
    {
        /// <summary>
        /// Process a csv file that contains ski station data
        /// </summary>
        /// <param name="path">string : the path to the csv file</param>
        /// <param name="separator">char : the separator of the csv file</param>
        /// <returns>A IEnumarable of SkiStation from the csv file</returns>
        public static IEnumerable<SkiStation> ProcessCSV(string path, char separator)
        {
            return File.ReadAllLines(path)
                .Skip(1)
                .Where(row => row.Length > 0)
                .Select(row => new SkiStation(row, separator)).ToList();
        }
    }
}
