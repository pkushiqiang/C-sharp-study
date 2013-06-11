using System;
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

namespace TestUIApp1.NoteControls
{
    public sealed partial class SidePanel : UserControl
    {

        private StackPanel lastVisiblePanel;

        public SidePanel()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PanelButton btn = (PanelButton)sender;
            System.Diagnostics.Debug.WriteLine(btn.Content);
            String panelName = btn.panelName;

            StackPanel panels = (StackPanel)this.FindName("rightPanel");
            StackPanel panel = (StackPanel)panels.FindName(panelName);
            if (lastVisiblePanel != panel)
            {
                if (lastVisiblePanel != null) lastVisiblePanel.Visibility = Visibility.Collapsed;
                panel.Visibility = Visibility.Visible;
                lastVisiblePanel = panel;
            }
        }

        private void color_btn_click(object sender, RoutedEventArgs e)
        {

        }
    }
}
