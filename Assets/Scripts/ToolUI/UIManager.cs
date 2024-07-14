using ToolExtension;

namespace ToolUI
{
    public class UIManager : SingletonClass<UIManager>
    {
        protected override void Awake()
        {
            base.Awake();
            NLogger.Log("UI Init");
        }
    }
}
