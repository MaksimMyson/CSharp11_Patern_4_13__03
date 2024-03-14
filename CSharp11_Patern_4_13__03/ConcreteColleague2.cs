using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp11_Patern_4_13__03
{
    class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(string name) : base(name) { }

        public override void Send(string message)
        {
            Console.WriteLine($"Повідомлення від {Name}: {message}");
            mediator.Send(message, this);
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"Колега {Name} отримав повідомлення: {message}");
        }
    }
}
