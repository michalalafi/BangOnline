using BangOnlineStructures.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangOnlineCommands
{
    public static class CommandController
    {
        public enum Commands
        {
            EXIT,
            START_NEW_GAME
        }
        private static readonly Dictionary<string, Commands> StringToCommand = new Dictionary<string, Commands>()
        {
            { "quit", Commands.EXIT},
            { "q", Commands.EXIT},
            { "new game", Commands.START_NEW_GAME }
        };


        public static Commands GetCommand(string command)
        {
            return StringToCommand[command];
        }
    }
}
