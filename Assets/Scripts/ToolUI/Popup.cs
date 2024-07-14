using ToolExtension;
using UnityEngine;

namespace ToolUI
{
    public abstract class Popup<T> : MonoBehaviour where T : PopupData
    {
        [SerializeField] protected T popupData;

        /// <summary>
        /// Assigned the On change value of the data to the Popup to visualize.
        /// </summary>
        public abstract void InitPopup();

        public virtual void Show()
        {
            NLogger.Log($"Show {gameObject}");
        }

        public virtual void Hide()
        {
            NLogger.Log($"Hide {gameObject}");
        }
        
    }
}