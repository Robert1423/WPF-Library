using Library.Core;
using System.Windows;
using System.Windows.Controls;


namespace Library.MVVM.View
{
    /// <summary>
    /// Logika interakcji dla klasy ReaderView.xaml
    /// </summary>
    public partial class ReaderView : UserControl
    {
        public ReaderView()
        {
            InitializeComponent();            
            this.DataContext = GlobalData.LibraryData; //przypisanie, gdzie ma szukać przypisanych właściwości
            //przy tworzeniu widoku, ustawianie wybranego reader na -1, nie wybrane
            GlobalData.LibraryData.SelectedReader = -1; 

        }

        private void DeleteReader_Click(object sender, RoutedEventArgs e)
        {
            //usunięcie wybranego wiersza z bazy w przypadku jeżeli baza nie jest pusta
            if (GlobalData.LibraryData.readerBase.Size() > 0)
            {
                GlobalData.LibraryData.readerBase.RemoveReader(GlobalData.LibraryData.SelectedReader);
            }
        }
    }
}
