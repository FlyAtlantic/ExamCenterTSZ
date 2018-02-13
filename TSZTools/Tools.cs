using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TSZTools
{
    public static class Metars
    {

        public static string Metar
        { get; set; }


        public static void GetMetars(string ICAO)
        {

            var webRequest = WebRequest.Create(@"http://metar.vatsim.net/metar.php?id=" + ICAO + "");

            using (var response = webRequest.GetResponse())
            using (var content = response.GetResponseStream())
            using (var reader = new StreamReader(content))
            {
                var strContent = reader.ReadToEnd();

                Metar = strContent;
            }
        }
    }

    public static class OceanicReport
    {

        public static string GeneratedReport
        { get; set; }

        public static void OceanicReports(string callsign, string position, int hourPosition, int minutePosition, int flightLevel, string nextposition, int hourNextPosition, int minuteNextPosition, string then, int mach)
        {
            string TimePosition = String.Format("{0}{1}z", hourPosition, minutePosition);
            string NextTimePosition = String.Format("{0}{1}z", hourNextPosition, minuteNextPosition);

            GeneratedReport = String.Format("TSZ{0} is position {0} at time {0} zulu, Flight Level {0} ,estimating {0} at {0} zulu, {0} the next, Mach {0}", callsign, position, TimePosition, flightLevel, NextTimePosition, then, mach);

        }
    }
}
