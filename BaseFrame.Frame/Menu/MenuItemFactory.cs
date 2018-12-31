using BaseFrame.Core;
using System.Linq;

namespace BaseFrame.Frame
{
    public class MenuItemFactory
    {
        /// <summary>
        /// 从
        /// </summary>
        /// <param name="menuPlugin"></param>
        /// <returns></returns>
        public MenuItem GetMenuItem(MenuPlugin menuPlugin)
        {
            MenuItem item = null;
            if (menuPlugin.AssemblyName != string.Empty && menuPlugin.AssemblyName != null
                && menuPlugin.ClassName != string.Empty && menuPlugin.ClassName != null)
            {
                string assemblyPath = AssemblyToolkit.GetDll(menuPlugin.AssemblyName);
                Command cmd = AssemblyToolkit.ActivateObject<Command>(assemblyPath, menuPlugin.ClassName);
                item = new MenuItem(cmd);
            }
            else
            {
                item = new MenuItem();
            }
            if (menuPlugin.Image != string.Empty && menuPlugin.Image != null)
            {
                string imagePath = CommonToolkit.GetResourceDirectory(menuPlugin.Image);
                item.Image = CommonToolkit.GetResourceImage(imagePath);
            }
            item.Text = (menuPlugin.Label.Equals(string.Empty) || menuPlugin.Label.Equals(null)) ? CommonToolkit.GetLastString(menuPlugin.Path) : menuPlugin.Label;
            return item;
        }

        public MenuItem GetMenuItem(string label)
        {
            MenuItem item = new MenuItem();
            item.Text = label;
            return item;
        }
    }
}
