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

namespace f
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Black(object sender, RoutedEventArgs e)
        {
            attributes.Color = Colors.Black;
        }

        private void White(object sender, RoutedEventArgs e)
        {
            attributes.Color = Colors.White;
        }

        private void Blue(object sender, RoutedEventArgs e)
        {
            attributes.Color = Colors.Blue;
        }

        private void Height(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            attributes.Height = e.NewValue;
        }
        private void Width(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            attributes.Width = e.NewValue;
        }

        private void ink_Checked(object sender, RoutedEventArgs e)
        {
            canvas.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void select_Checked(object sender, RoutedEventArgs e)
        {
            canvas.EditingMode = InkCanvasEditingMode.Select;

        }

        private void erase_Checked(object sender, RoutedEventArgs e)
        {
            canvas.EditingMode = InkCanvasEditingMode.EraseByStroke;
        }

    }
}
