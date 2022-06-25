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
    /// Logika interakcji dla klasy FinishRentView.xaml
    /// </summary>
    public partial class FinishRentView : UserControl
    {
        public string rentTitle { get; set; }
        public string rentReader { get; set; }
        public FinishRentView()
        {
            InitializeComponent();
            this.DataContext = this;
            if (GlobalData.LibraryData.SelectedTitle >= 0)
            {
                rentTitle = GlobalData.LibraryData.titleBase.titles[GlobalData.LibraryData.SelectedTitle]._id;
                GlobalData.LibraryData.SelectedTitle = -1; //reset wyboru
            }
            if (GlobalData.LibraryData.SelectedReader >= 0)
            {
                rentReader = GlobalData.LibraryData.readerBase.readers[GlobalData.LibraryData.SelectedReader]._id;
                GlobalData.LibraryData.SelectedReader = -1; //reset wyboru
            }
        }

        private void AcceptFinishRent_Click(object sender, RoutedEventArgs e)
        {
            int readerInBase = GlobalData.LibraryData.readerBase.Find(rentReader);
            int titleInBase = GlobalData.LibraryData.titleBase.Find(rentTitle);
            int rentInBase = GlobalData.LibraryData.rentBase.Find(rentTitle);
            if (rentInBase<0)
            {
                MessageWindow message = new MessageWindow("Błąd!", "Nie znaleziono wypożyczenia o \npodanych danych");
                message.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                message.ShowDialog();
                rentTitle = string.Empty;
                rentReader = string.Empty;
                TitleFinishBox.Text = string.Empty;
                ReaderFinishBox.Text = string.Empty;
                return;
            }
            if (readerInBase >= 0 && titleInBase >=0)
            {
                int rentInReader = GlobalData.LibraryData.readerBase.readers[readerInBase].FindRent(rentTitle);
                GlobalData.LibraryData.rentBase.RemoveRent(rentInBase);
                GlobalData.LibraryData.readerBase.readers[readerInBase].FinishRent(rentInReader);
                GlobalData.LibraryData.titleBase.titles[titleInBase].FinishRent();
            }
            else
            {
                MessageWindow message = new MessageWindow("Błąd!", "Podanych danych nie znaleziono w bazie");
                message.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                message.ShowDialog();
            }
            rentTitle = string.Empty;
            rentReader = string.Empty;
            TitleFinishBox.Text = string.Empty;
            ReaderFinishBox.Text = string.Empty;
        }

        private void RejectFinishRent_Click(object sender, RoutedEventArgs e)
        {
            rentTitle = string.Empty;
            rentReader = string.Empty;
            TitleFinishBox.Text = string.Empty;
            ReaderFinishBox.Text = string.Empty;
        }
    }
}
