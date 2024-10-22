﻿using Fasetto.ViewModels;
using System.Windows.Controls;

namespace Fasetto.Controls
{
    /// <summary>
    /// SideMenuControl.xaml 的交互逻辑
    /// </summary>
    public partial class SideMenuControl : UserControl
    {
        public SideMenuControl()
        {
            InitializeComponent();
            DataContext = new SideMenuViewModel();
        }
    }
}
