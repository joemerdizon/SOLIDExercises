using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{


    public class JohnDoe
    {
        private readonly ICompetition _competition;
        private readonly IJump _jump;

        public JohnDoe(ICompetition competition)
        {
            _competition = competition;
        }

        public void Compete()
        {
            _competition.Compete();
        }

        
    }
}
