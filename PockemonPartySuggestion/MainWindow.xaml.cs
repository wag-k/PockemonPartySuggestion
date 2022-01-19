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

namespace PockemonPartySuggestion
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

        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            // Set tooltip visibility
            if(ToggleBtnMenu.IsChecked == true){
                SwitchListViewToolTip(Visibility.Collapsed);
            } else{
                SwitchListViewToolTip(Visibility.Visible);
            }
        }

        void SwitchListViewToolTip(Visibility visibility){
            // Set tooltip visibility
            HomeToolTip.Visibility = visibility;
            AnalysisToolTip.Visibility = visibility;
            SuggestionToolTip.Visibility = visibility;
        }

        private void ToggleBtnMenu_Unchecked(object sender, RoutedEventArgs e)
        {
            BackgroundImageBrush.Opacity = 1;
        }

        private void ToggleBtnMenu_Checked(object sender, RoutedEventArgs e)
        {
            BackgroundImageBrush.Opacity = 0.3;
        }

        private void GridBackground_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ToggleBtnMenu.IsChecked = false;
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
