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

namespace Content
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            StackPanel stackPanel = new StackPanel();

            stackPanel.Children.Add(new TextBox { Text = " hey" , Background = new SolidColorBrush (Colors.Red), Width = 20, Height = 20 });
            stackPanel.Children.Add(new Button { Content = "Press", FontSize = 22, Height = 50, Cursor = Cursors.Arrow });

            b.Content = stackPanel;

        }
    }
}
