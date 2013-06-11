﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace FileManage.controls
{
    public sealed partial class RightPanel : UserControl
    {
        public RightPanel()
        {
            this.InitializeComponent();
        }

        private void clicktocanvas(object sender, RoutedEventArgs e)
        {
            Frame rootFrame = (Frame)Window.Current.Content;
            rootFrame.Navigate(typeof(CanvasPage));
        }
    }
}
