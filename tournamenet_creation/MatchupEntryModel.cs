using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tournamenet_creation
{
    public class MatchupEntryModel
    {
        /*<summary>
         * Represents one team in the matchup.
         * </summary>
         */

        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents score for a particular team
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represents the matchup that this came from
        /// as the winner
        /// </summary>
        public MatchupModel ParentMatchup {get; set;}
    }
}
