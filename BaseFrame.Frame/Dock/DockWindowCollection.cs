using System.Collections.Generic;

namespace BaseFrame.Frame
{
    public class DockWindowCollection
    {
        private static List<ToolWindow> _dockWindows = new List<ToolWindow>();

        public static void Add(ToolWindow dockWindow)
        {
            _dockWindows.Add(dockWindow);
        }

        public static List<ToolWindow> GetCollection()
        {
            return _dockWindows;
        }
    }
}
