using System;
using System.Collections.Generic;

namespace ToolExtension.ObserverPattern
{
    public abstract class NAction<T>
    {
        private List<Action<T>> _listAction;

        public void AddAction(Action<T> action, int order = 0)
        {
            if(order == 0) 
                _listAction.Add(action);
            else 
                _listAction.Insert(order, action);
        }

        public void RemoveAction(Action<T> action)
        {
            _listAction.Add(action);
        }

        public void Broadcast(T param)
        {
            foreach (var action in _listAction)
            {
                action?.Invoke(param);
            }
        }
        
    }
}