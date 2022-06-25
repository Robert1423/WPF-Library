using Library.Core;
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

namespace Library.MVVM.View
{
    /// <summary>
    /// Logika interakcji dla klasy RentsView.xaml
    /// </summary>
    public partial class RentsView : UserControl
    {
        public RentsView()
        {
            InitializeComponent();
            this.DataContext = GlobalData.LibraryData;
        }
    }
}
