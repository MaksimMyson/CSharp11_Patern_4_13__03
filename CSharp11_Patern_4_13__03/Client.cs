using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp11_Patern_4_13__03
{
    public class Client
    {
        public void Main()
        {
            
            Handler handler1 = new ConcreteHandler1();
            Handler handler2 = new ConcreteHandler2();
            Handler handler3 = new ConcreteHandler3();

            
            handler1.SetSuccessor(handler2);
            handler2.SetSuccessor(handler3);

           
            int[] requests = { 2, 5, 14, 22, 28 };

            foreach (int request in requests)
            {
                handler1.HandleRequest(request);
            }
        }
    }
}
