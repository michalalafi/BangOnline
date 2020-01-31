using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangOnlineRules
{
    public static class RulesController
    {
        private const int MIN_PLAYERS = 3;
        private const int MAX_PLAYERS = 8;

        public static int SetToValidPlayersCount(int numberOfPlayers)
        {
            if(numberOfPlayers < MIN_PLAYERS)
            {
                return MIN_PLAYERS;
            }
            else if(numberOfPlayers > MAX_PLAYERS)
            {
                return MAX_PLAYERS;
            }
            return numberOfPlayers;
        }
    }
}
