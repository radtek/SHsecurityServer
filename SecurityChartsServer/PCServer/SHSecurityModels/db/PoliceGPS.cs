using System;
using System.Collections.Generic;
using System.Text;

namespace SHSecurityModels
{
    public class PoliceGPS
    {
        public int Id { get; set; }
        public string PoliceID { get; set; }
        public string GPS_X { get; set; }
        public string GPS_Y { get; set; }

        public int Timestamp { get; set; }
        
        public string Year { get; set; }
        public string Month { get; set; }
        public string Day { get; set; }
        public string HH { get; set; }
        public string MM { get; set; }
        public string SS { get; set; }

    }
}
