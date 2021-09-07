using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympicsWebApp.BusinessLayer
{
    public class Coach
    {
        // Represent Coach ID
        public int Id { get; set; }

        // Represent Coach Name
        public string CoachName { get; set; }

        // Represent Country ID
        public int CountryID { get; set; }

        public Country Country{ get; set; }

        // Represent Discipline ID
        public int DisciplineID { get; set; }

        public Discipline Discipline { get; set; }
    }
}
