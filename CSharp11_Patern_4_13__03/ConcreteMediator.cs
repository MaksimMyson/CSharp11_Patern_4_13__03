using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp11_Patern_4_13__03
{
    class ConcreteMediator : IMediator
    {
        private Dictionary<string, Colleague> colleagues = new Dictionary<string, Colleague>();

        public void Register(Colleague colleague)
        {
            if (!colleagues.ContainsKey(colleague.Name))
            {
                colleagues[colleague.Name] = colleague;
                colleague.SetMediator(this);
            }
        }

        public void Send(string message, Colleague colleague)
        {
            foreach (var pair in colleagues)
            {
                if (pair.Value != colleague) // Не відправляємо повідомлення самому собі
                    pair.Value.Receive(message);
            }
        }
    }
}
