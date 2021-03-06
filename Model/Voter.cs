using Commons.Enums;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Voter : BaseEntity
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string Phote { get; set; }
        public string Registration_No { get; set; }
        public DateTime DateOfBirth { get; set; }
        public PollingUnit PollingUnit { get; set; }
        public bool HasVoted { get; set; }

        public Voter()   
        {
            Registration_No = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 6);
        }

        public Voter(string regNo, string id) : base(id)
        {
            Registration_No = regNo;
        } 
    }
}