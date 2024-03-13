using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp11_Patern_4_13__03
{
    public class Light
    {
        private int _brightness;

        public void TurnOn()
        {
            Console.WriteLine("Світлодіодний ліхтарик увімкнено");
            _brightness = 100;
        }

        public void TurnOff()
        {
            Console.WriteLine("Світлодіодний ліхтарик вимкнено");
            _brightness = 0;
        }

        public void ChangeBrightness(int brightness)
        {
            Console.WriteLine($"Яскравість ліхтарика змінено на {brightness}%");
            _brightness = brightness;
        }
    }
}
