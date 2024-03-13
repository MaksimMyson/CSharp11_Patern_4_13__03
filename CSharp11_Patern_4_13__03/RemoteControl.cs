using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CSharp11_Patern_4_13__03
{
    public class RemoteControl
    {
        private ICommand? _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void PressButton(object? parameter)
        {
            _command?.Execute(parameter);
        }
    }
}
