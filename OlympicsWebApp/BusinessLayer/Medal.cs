using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympicsWebApp.BusinessLayer
{
    public class Medal
    {
        // Represent Coach ID
        public int Id { get; set; }

        // Represent Total Gold
        public int GoldMedal { get; set; }

        // Represent Total Bronze
        public int BronzeMedal { get; set; }

        // Represent Total Silver
        public int SilverMedal { get; set; }

        // Represent Country ID
        public int CountryID { get; set; }

        public Country Country { get; set; }
    }
}
