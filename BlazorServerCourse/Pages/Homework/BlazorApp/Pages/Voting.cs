using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Pages
{
    public partial class Voting
    {
        private int condidate1Votes;
        private int condidate2Votes;

        private void VoteCandidate1()
        {
            condidate1Votes++;
        }
        private void VoteCandidate2()
        {
            condidate2Votes++;
        }
    }
}
