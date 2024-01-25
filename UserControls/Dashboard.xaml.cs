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

namespace WPFDashboard3.UserControls
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : UserControl
    {
        public static readonly DependencyProperty TopImageProperty = DependencyProperty.Register(
           "TopImage",
           typeof(ImageSource),
           typeof(Dashboard)
        );
        public static readonly DependencyProperty BottomImageProperty = DependencyProperty.Register(
           "BottomImage",
           typeof(ImageSource),
           typeof(Dashboard)
        );
        public ImageSource TopImage
        {
            get => (ImageSource)GetValue(TopImageProperty);
            set => SetValue(TopImageProperty, value);
        }
        public ImageSource BottomImage
        {
            get => (ImageSource)GetValue(BottomImageProperty);
            set => SetValue(BottomImageProperty, value);
        }
        public Dashboard()
        {
            InitializeComponent();
        }
    }
}
