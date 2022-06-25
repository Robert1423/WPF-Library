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
    /// Logika interakcji dla klasy ReaderAdd.xaml
    /// </summary>
    public partial class ReaderAdd : UserControl
    {
        public string redearName { get; set; }
        public ReaderAdd()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void AddReaderBtn_Click(object sender, RoutedEventArgs e)
        {
            
            if (redearName != string.Empty)
            {
                int idCheck = GlobalData.LibraryData.readerBase.CheckAvalaibleID();
                if (idCheck >= 0)
                {
                    Reader temp = new Reader(redearName, idCheck+1);
                    GlobalData.LibraryData.readerBase.Insert(temp, idCheck);
                }
                else
                {
                    Reader temp = new Reader(redearName, GlobalData.LibraryData.readerBase.Size() + 1);
                    GlobalData.LibraryData.readerBase.AddReader(temp);
                }
            }
            fullName.Text = string.Empty;
            redearName = string.Empty;
        }

        private void CancelReaderBtn_Click(object sender, RoutedEventArgs e)
        {
            fullName.Text = string.Empty;
            redearName = string.Empty;
        }
    }
}
