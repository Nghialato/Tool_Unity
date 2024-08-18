using System;
using System.Collections.Generic;

namespace ToolExtension.ObserverPattern
{
    public class NAction<T>
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
            _listAction.Remove(action);
        }

        public void Broadcast(T param)
        {
            foreach (var action in _listAction)
            {
                action?.Invoke(param);
            }
        }
    }
    
    public class NAction
    {
        private List<Action> _listAction;

        public void AddAction(Action action, int order = 0)
        {
            if(order == 0) 
                _listAction.Add(action);
            else 
                _listAction.Insert(order, action);
        }

        public void RemoveAction(Action action)
        {
            _listAction.Remove(action);
        }

        public void Broadcast()
        {
            foreach (var action in _listAction)
            {
                action?.Invoke();
            }
        }
    }
    
    public class NAction<T, T1>
    {
        private List<Action<T, T1>> _listAction;

        public void AddAction(Action<T, T1> action, int order = 0)
        {
            if(order == 0) 
                _listAction.Add(action);
            else 
                _listAction.Insert(order, action);
        }

        public void RemoveAction(Action<T, T1> action)
        {
            _listAction.Remove(action);
        }

        public void Broadcast(T param, T1 param1)
        {
            foreach (var action in _listAction)
            {
                action?.Invoke(param, param1);
            }
        }
        
    }
}