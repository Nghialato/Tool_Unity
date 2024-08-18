using System;

namespace ToolExtension.ObserverPattern
{
    /// <summary>
    /// This contains all the Event that Created
    /// </summary>
    public static class EventManager
    {
        // Create a System that can handle the order of the action

        public static NAction<int> OnWinNAction;
        
        public static Action<int> OnLoseAction;

    }
}