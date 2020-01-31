using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BangOnlineInterfaces.App;
using BangOnlineStructures.Players;
namespace BangOnlineStructures.Games
{
    /// <summary>
    /// Třída reprezentující konkrétní hru s několika hráči
    /// </summary>
    public class Game : AbstractGame
    {
        /// <summary>
        /// Beží hra?
        /// </summary>
        private bool Running { get; set; }
        /// <summary>
        /// Seznam hráčů
        /// </summary>
        private List<Player> Players { get; set; }
        /// <summary>
        /// Aktivní hráč
        /// </summary>
        private int ActivePlayer { get; set; }
        public Game(int numberOfPlayers)
        {
            numberOfPlayers = BangOnlineRules.RulesController.SetToValidPlayersCount(numberOfPlayers);
            this.Running = true;
            this.ActivePlayer = 0;
            this.Players = new List<Player>();
            for (int i = 0; i < numberOfPlayers; i++)
            {
                this.Players.Add(new Player
                {
                    PlayerRole = new Roles.Role { Name = "Bandita" }
                });
            }
        }
        public Game() : this(3)
        {

        }
        public void NextPlayer()
        {
            this.ActivePlayer = (this.ActivePlayer + 1) % this.Players.Count;
        }
        public override string ToString()
        {
            var result = 
                $"GAME:\n" +
                $"  Running: {this.Running}\n" +
                $"  ActivePlayer: {this.ActivePlayer}\n" +
                $"  Number of players: {this.Players.Count}\n";
            for (int i = 0; i < this.Players.Count; i++)
            {
                result += $"Player[{i}] is {this.Players[i].PlayerRole.Name}\n";
            }

            return result;
        }
    }
}
