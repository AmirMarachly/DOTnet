using System;
using System.Linq;

namespace Station_de_ski
{
    class SkiStation
    {

        public string Name { get; }
        public string DomainName { get; }
        public string Canton { get; }
        public double? Altitude { get; }
        public double? MaxAltitude { get; }
        public double? Latitude { get; }
        public double? Longitude { get; }
        public double? AdultRate { get; }
        public double? ChildRate { get; }
        public double? NumberOfLifts { get; }
        public double? NumberOfSlopes { get; }
        public double? LengthOfSlopes { get; }

        /// <summary>
        /// Constructor of the SkiStation class
        /// </summary>
        /// <param name="row">string : A row from a csv file</param>
        /// <param name="separator">char : the separator used in the csv file </param>
        public SkiStation(string row, char separator)
        {
            string[] column = row.Split(separator);

            Name = column.ElementAtOrDefault(0);
            DomainName = column.ElementAtOrDefault(1);
            Canton = column.ElementAtOrDefault(2);
            Altitude = StringToDouble(column.ElementAtOrDefault(3));
            MaxAltitude = StringToDouble(column.ElementAtOrDefault(4));
            Latitude = StringToDouble(column.ElementAtOrDefault(5));
            Longitude = StringToDouble(column.ElementAtOrDefault(6));
            AdultRate = StringToDouble(column.ElementAtOrDefault(7));
            ChildRate = StringToDouble(column.ElementAtOrDefault(8));
            NumberOfLifts = StringToDouble(column.ElementAtOrDefault(9));
            NumberOfSlopes = StringToDouble(column.ElementAtOrDefault(10));
            LengthOfSlopes = StringToDouble(column.ElementAtOrDefault(11));

        }

        /// <summary>
        /// Convert a string to a double
        /// </summary>
        /// <param name="s">string : the string to be convert</param>
        /// <returns>the convertion of the string if it's possible, otherwise return null</returns>
        private static double? StringToDouble(string s)
        {
            if (double.TryParse(s, out double o))
            {
                return double.Parse(s);
            }

            return null;
        }

        public override string ToString()
        {
            string str = "";

            foreach(var prop in GetType().GetProperties())
            {
                str += prop.GetValue(this, null) + ",";
            }

            return str.Remove(str.Length - 1);
        }
    }
}