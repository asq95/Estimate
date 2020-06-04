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

namespace EstimateApp
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

        private void SelectMenuButtonClick(object sender, RoutedEventArgs e)
        {
            //GridCursor.Width = 0;
            int index = int.Parse(((Button)e.Source).Uid);

            GridCursor.Margin = new Thickness(10 + (GridCursor.Width * index), 0, 0, 0);

            switch (index)
            {
                case 0:
                    CreateNewEstimatePanel.Visibility = Visibility.Visible;
                    CreateNewTemplatePanel.Visibility = Visibility.Collapsed;
                    EditExistingTemplate.Visibility = Visibility.Collapsed;
                    SettingsPanel.Visibility = Visibility.Collapsed;
                    break;
                case 1:
                    CreateNewEstimatePanel.Visibility = Visibility.Collapsed;
                    EditExistingTemplate.Visibility = Visibility.Collapsed;
                    CreateNewTemplatePanel.Visibility = Visibility.Visible;
                    SettingsPanel.Visibility = Visibility.Collapsed;
                    break;
                case 2:
                    CreateNewEstimatePanel.Visibility = Visibility.Collapsed;
                    CreateNewTemplatePanel.Visibility = Visibility.Collapsed;
                    EditExistingTemplate.Visibility = Visibility.Visible;
                    SettingsPanel.Visibility = Visibility.Collapsed;

                    break;
                case 3:

                    CreateNewEstimatePanel.Visibility = Visibility.Collapsed;
                    CreateNewTemplatePanel.Visibility = Visibility.Collapsed;
                    EditExistingTemplate.Visibility = Visibility.Collapsed;
                    SettingsPanel.Visibility = Visibility.Visible;
                    break;
            }
            
        }

        private void ExitButtonClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddNewEstimate(object sender, RoutedEventArgs e)
        {

        }

        private void ChooseTemplate(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
