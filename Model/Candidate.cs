using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Candidate : BaseEntity
    {
        public string Name { get; set; }

        public Election Election { get; set; }
        public Party Party { get; set; }

        public Election ElectionContested { get; set; }

        public Candidate()
        {
        } 

        public Candidate(string id) : base(id)
        {
        }
      
    }
}

