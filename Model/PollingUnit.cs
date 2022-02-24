using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PollingUnit: BaseEntity
    {
        public string Unit_No { get; }

        public string LocalGovernment { get; }

        public string PollingUnitCode { get; set; }

        public IList<Voter> Voters { get; set; }

        public PollingUnit(string LGA)
        {
            LocalGovernment = LGA;
            Unit_No = $"{LGA}-{Guid.NewGuid().ToString().Replace("-", "").Substring(0, 6)}";
           
        }

        public PollingUnit(string LGA, string unitNo, string id) : base(id)
        {
            LocalGovernment= LGA;   
            Unit_No= unitNo;
        }

    }


}
