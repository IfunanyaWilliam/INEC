using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Models.Enums;

namespace Data
{
    public class Database 
    {
        public static IList<Voter> VoterTable { get; set; }
        public static IList<Candidate> CandidateTable { get; set; } = new List<Candidate>();

        public static IList<Election> ElectionTable { get; set; } = new List<Election>();

        public static IList<Party> PartyTable { get; set; }= new List<Party>();

        public static IList<PollingUnit> PollingUnitTable { get; set;} = new List<PollingUnit>();


    }
}