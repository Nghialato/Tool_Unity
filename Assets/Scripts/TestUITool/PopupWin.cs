using ToolExtension;
using ToolUI;
using Unity.VisualScripting;

namespace TestUITool
{
    public class PopupWin : Popup<PopupDataWin>
    {
        public override void InitPopup()
        {
            
        }

        public override void Show()
        {
            base.Show();
            NLogger.Log(popupData);
        }
    }
}