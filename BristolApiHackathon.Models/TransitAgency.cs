using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BristolApiHackathon.Models
{
    public class TransitAgency
    {
        public string AgencyID { get; set; }
        public string AgencyName { get; set; }
        public string AgencyURL { get; set; }
        public string AgencyTimeZone { get; set; }
        public string AgencyLanguage { get; set; }
        public string AgencyPhone { get; set; }
        public string AgencyFareURL { get; set; }
        public string AgencyRegion { get; set; }
        public string AgencyImportSource { get; set; }
    }
}
