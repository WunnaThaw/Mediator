using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ConcreteColleague<T> : IColleague<T>
    {
        private string name;

        public ConcreteColleague(string name)
        {
            this.name = name;
        }

        void IColleague<T>.SendMessage(IMediator<T> mediator, T message)
        {
            mediator.DistributeMessage(this, message);
        }

        void IColleague<T>.ReceiveMessage(T message)
        {
            Console.WriteLine(this.name + " received " + message.ToString());
        }
    }
}
