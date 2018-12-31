﻿using System.ComponentModel;

namespace BaseFrame.Dock
{
    public abstract class ThemeBase : Component, ITheme
    {
        public DockPanelSkin Skin { get; protected set; }

        public abstract void Apply(DockPanel dockPanel);
    }
}
