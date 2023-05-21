using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public interface IColleague<T>
    {
        void SendMessage(IMediator<T> mediator, T message);

        void ReceiveMessage(T message);
    }
}
