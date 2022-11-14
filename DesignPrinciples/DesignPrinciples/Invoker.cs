using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples
{
    class Invoker
    {
        private ICommand command;
        public void SetCommand(ICommand command)
        {
            this.command = command;
        }
        public void Execute()
        {
            command.Execute();
        }
    }
}
