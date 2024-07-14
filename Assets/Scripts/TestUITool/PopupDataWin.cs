using ToolUI;
using UnityEngine;

namespace TestUITool
{
    [CreateAssetMenu(menuName = "Popup Data/Popup Data Win", fileName = "Popup Data Win")]
    public class PopupDataWin : PopupData
    {
        [SerializeField] private int levelWin;

        public int LevelWin
        {
            get => levelWin;
            set
            {
                if (levelWin == value) return;
                OnDataChange?.Invoke();
                levelWin = value;
            }
        }
    }
}