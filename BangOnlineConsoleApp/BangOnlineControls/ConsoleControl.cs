using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BangOnlineInterfaces.App;
namespace BangOnlineControls
{
    public class ConsoleControl : IRunnable
    {
        private bool Running { get; set; }
        public void Run()
        {
            while (this.Running)
            {

            }

            this.Exit();
        }
        public void Exit()
        {
            throw new NotImplementedException();
        }

    }
}
