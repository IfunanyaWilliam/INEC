using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Enums;
  
namespace Models
{
    public class Election : BaseEntity 
    {
        public ElectionType Type { get; set; }


        //Could be ward, local government, state
        public string Location { get; set; }

        public Candidate Winner { get; set; } 

        public Candidate FirstRunnerUP { get; set; }

        public Candidate SecondRunnerUP { get; set; }

        public IList<Candidate> Contenders { get; set; }

        public Election()
        {
        }

        public Election(string id) : base(id)
        {
        }
    }
}

