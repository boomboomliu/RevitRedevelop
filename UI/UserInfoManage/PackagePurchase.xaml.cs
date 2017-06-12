﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Autodesk.Revit.UI;

namespace RevitRedevelop.UI
{
    /// <summary>
    /// PackagePurchase.xaml 的交互逻辑
    /// </summary>
    public partial class PackagePurchase : Page, Autodesk.Revit.UI.IDockablePaneProvider
    {
        public PackagePurchase()
        {
            InitializeComponent();
        }
         private Autodesk.Revit.UI.UIApplication app;
        public void SetupDockablePane(DockablePaneProviderData data)
        {
            
            data.FrameworkElement = this as FrameworkElement;
            DockablePaneProviderData d = new DockablePaneProviderData();

            data.InitialState = new Autodesk.Revit.UI.DockablePaneState();
         //   data.InitialState.SetFloatingRectangle(new Autodesk.Revit.UI.Rectangle(0,100,200,200));
            data.InitialState.DockPosition = Autodesk.Revit.UI.DockPosition.Tabbed;
        }
    }
}