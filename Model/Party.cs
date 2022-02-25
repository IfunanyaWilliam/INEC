using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Models
{
    public class Party : BaseEntity
    {
        public string Name { get; set; }

        public int Votes { get; set; }

        public IList<Candidate> Candidates { get; set; }

        public Party()
        {
        }

        public Party(string id) : base(id)
        {
        }
    }
}

