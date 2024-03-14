using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp11_Patern_4_13__03
{
    abstract class Colleague
    {
        protected IMediator mediator;
        public string Name { get; }

        public Colleague(string name)
        {
            Name = name;
        }

        public void SetMediator(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}
