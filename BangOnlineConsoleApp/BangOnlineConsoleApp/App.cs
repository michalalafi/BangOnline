using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BangOnlineInterfaces.App;
using BangOnlineControls;
using BangOnlineCommands;
using BangOnlineStructures.Games;

namespace BangOnlineConsoleApp
{
    public class App : IRunnable, IControlable
    {
        /// <summary>
        /// Instance aplikace
        /// </summary>
        private static App instance = null;
        /// <summary>
        /// Bezi aplikace?
        /// </summary>
        private bool Running { get; set; }
        /// <summary>
        /// Viditelna instance aplikace
        /// </summary>
        public static App Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new App();
                }
                return instance;
            }
        }

        private Game game { get; set; }
        private App()
        {
            this.Running = true;
        }
        /// <summary>
        /// Metoda pro beh aplikace
        /// Obsahuje nekonecnou smycku, ktera zpracovava uzivatelsky vstup
        /// </summary>
        public void Run()
        {
            Console.WriteLine("=========== App is running ===========");
            while (this.Running)
            {
                Console.Write("Insert input: ");

                this.Control(Console.ReadLine());                
            }

            this.Exit();
        }
        public void Control(string input)
        {
            CommandController.Commands command = CommandController.GetCommand(input); 
            switch (command)
            {
                case CommandController.Commands.EXIT:
                    this.Running = false;
                    break;
                case CommandController.Commands.START_NEW_GAME:
                    Console.Write("How much players:");
                    this.game = new Game(int.Parse(Console.ReadLine()));
                    Console.WriteLine(this.game.ToString());
                    break;
                default:
                    break;
            }
        }
        public void Exit()
        {
            Console.WriteLine("=========== App is turning off ===========");
            Console.WriteLine("PRESS ENTER");
            Console.ReadLine();
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
