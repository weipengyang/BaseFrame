﻿using System.Drawing;

namespace BaseFrame.Core
{
    public partial class CommonToolkit
    {
        public static Image GetResourceImage(string imgPath)
        {
            return Image.FromFile(imgPath);
        }
    }
}
