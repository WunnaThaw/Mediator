﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ConcreteMediator<T> : IMediator<T>
    {
        private List<IColleague<T>> colleagueList = new List<IColleague<T>>();

        List<IColleague<T>> IMediator<T>.ColleagueList
        {
            get { return colleagueList; }
        }

        void IMediator<T>.Register(IColleague<T> colleague)
        {
            colleagueList.Add(colleague);
        }

        void IMediator<T>.DistributeMessage(IColleague<T> sender, T message)
        {
            foreach (IColleague<T> c in colleagueList)
                if (c != sender)    //don't need to send message to sender
                    c.ReceiveMessage(message);
        }
    }
}
