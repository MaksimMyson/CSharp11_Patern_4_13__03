using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp11_Patern_4_13__03
{
    public class BrightnessCommand : ICommand
    {
        private readonly Light _light;
        private readonly int _brightness;

        public BrightnessCommand(Light light, int brightness)
        {
            _light = light;
            _brightness = brightness;
        }

        public void Execute(object? parameter)
        {
            _light.ChangeBrightness(_brightness);
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public event EventHandler? CanExecuteChanged;
    }
}
