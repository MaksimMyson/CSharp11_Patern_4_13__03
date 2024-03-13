using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp11_Patern_4_13__03
{
    public class TurnOffCommand : ICommand
    {
        private readonly Light _light;

        public TurnOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute(object? parameter)
        {
            _light.TurnOff();
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public event EventHandler? CanExecuteChanged;
    }
}
