using System;
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

namespace SlimmingWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Items_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Selection.Text = ((ContentControl)((object[])e.AddedItems)[0]).Content.ToString();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var button = (Button) sender;
            Selection.Background = button.Background;
        }
    }
}
