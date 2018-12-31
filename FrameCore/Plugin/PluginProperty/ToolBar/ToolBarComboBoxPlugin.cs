using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BaseFrame.Core
{
    public class ToolBarComboBoxPlugin : PluginBase
    {
        public string Id
        {
            get; set;
        }


        public void SetupPlugin(XmlReader reader)
        {
            do
            {
                if (reader.NodeType == XmlNodeType.EndElement
                 && reader.LocalName.Equals("ToolBarComboBox"))
                {
                    break;
                }
                if (reader.LocalName.Equals("ToolBarComboBox") && reader.IsStartElement())
                {
                    this.Path = reader.GetAttribute("path");
                    this.Id = reader.GetAttribute("id");

                    //初始化插件
                    InitializePlugin();
                    reader.MoveToElement();
                }
                if (reader.LocalName.Equals("ToolBarComboBoxItem") && reader.IsStartElement())
                {
                    ToolBarComboBoxItemPlugin comboBoxItemPlugin = new ToolBarComboBoxItemPlugin();
                    comboBoxItemPlugin.SetupPlugin(reader);
                }
            }
            while (reader.Read());
        }
    }
}
