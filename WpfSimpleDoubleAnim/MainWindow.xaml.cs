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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfSimpleDoubleAnim
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animX =
                new DoubleAnimation(500, TimeSpan.FromMilliseconds(1000));
            animX.RepeatBehavior = RepeatBehavior.Forever;
            animX.AutoReverse = true;

            DoubleAnimation animY =
                new DoubleAnimation(500, TimeSpan.FromMilliseconds(1000));
            animY.RepeatBehavior = RepeatBehavior.Forever;
            animY.AutoReverse = true;

            rect1.BeginAnimation(Canvas.LeftProperty, animX);
            rect1.BeginAnimation(Canvas.TopProperty, animY);
            DoubleAnimation boundsAnim =
                (DoubleAnimation)this.Resources["boundsAnim"];
            rect1.BeginAnimation(Rectangle.WidthProperty, boundsAnim);
            rect1.BeginAnimation(Rectangle.HeightProperty, boundsAnim);
            rect2.BeginAnimation(Rectangle.WidthProperty, boundsAnim);
            rect2.BeginAnimation(Rectangle.HeightProperty, boundsAnim);

            //MessageBox.Show(this.Width.ToString());
        }
    }
}
