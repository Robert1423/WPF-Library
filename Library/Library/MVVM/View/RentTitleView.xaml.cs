using Library.Core;
using System.Windows;
using System.Windows.Controls;

namespace Library.MVVM.View
{
    /// <summary>
    /// Logika interakcji dla klasy RentTitleView.xaml
    /// </summary>
    public partial class RentTitleView : UserControl
    {
        public string rentTitle { get; set; }
        public string rentReader { get; set; }
        public RentTitleView()
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

        private void AcceptRent_Click(object sender, RoutedEventArgs e)
        {
            //int readerInBase, titleInBase;
            //if (GlobalData.LibraryData.SelectedReader >= 0)
            //    readerInBase = GlobalData.LibraryData.SelectedReader;
            //else
            int readerInBase = GlobalData.LibraryData.FindReader(rentReader);
            //if (GlobalData.LibraryData.SelectedTitle >= 0)
            //    titleInBase = GlobalData.LibraryData.SelectedTitle;
            //else
            int titleInBase = GlobalData.LibraryData.FindTitle(rentTitle);
            if (readerInBase >= 0 && titleInBase >= 0)
            {
                if (GlobalData.LibraryData.titleBase.titles[titleInBase].CheckAvalaible())
                {
                    Rent rent = new Rent(GlobalData.LibraryData.titleBase.titles[titleInBase],
                        GlobalData.LibraryData.readerBase.readers[readerInBase]);
                    GlobalData.LibraryData.titleBase.titles[titleInBase].Rent();
                    GlobalData.LibraryData.readerBase.readers[readerInBase].AddRent(rent);
                    GlobalData.LibraryData.rentBase.AddRent(rent);
                    int size = GlobalData.LibraryData.rentBase.Size();
                    MessageWindow message = new MessageWindow("Wypożyczono",$"Wypożyczono czytelnikowi: " +
                        $"{GlobalData.LibraryData.rentBase.rents[size - 1]._rentedBy._name}");
                    message.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    message.ShowDialog();
                }
                else
                {
                    MessageWindow message = new MessageWindow("Błąd!","Brak pozycji na stanie!\nNie można wypożyczyć");
                    message.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    message.ShowDialog();
                }
            }
            else
            {
                MessageWindow message = new MessageWindow("Błąd!","Nie znaleziono w bazie!");
                message.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                message.ShowDialog();
            }
            rentReader = string.Empty;
            rentTitle = string.Empty;
            RentedTitle.Text = string.Empty;
            ReaderRent.Text = string.Empty;
        }

        private void RejectRent_Click(object sender, RoutedEventArgs e)
        {
            rentReader = string.Empty;
            rentTitle = string.Empty;
            RentedTitle.Text = string.Empty;
            ReaderRent.Text = string.Empty;
        }
    }
}
