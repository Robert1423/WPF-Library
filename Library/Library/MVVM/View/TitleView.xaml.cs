using Library.Core;
using System.Windows;
using System.Windows.Controls;

namespace Library.MVVM.View
{
    /// <summary>
    /// Logika interakcji dla klasy TitleView.xaml
    /// </summary>
    public partial class TitleView : UserControl
    {
        public TitleView()
        {
            InitializeComponent();
            this.DataContext = GlobalData.LibraryData;
            //przy tworzeniu widoku, ustawianie wybranego zasobu na -1, nie wybrane
            GlobalData.LibraryData.SelectedTitle = -1;
        }

        private void RemoveTitle_Click(object sender, RoutedEventArgs e)
        {
            GlobalData.LibraryData.titleBase.RemoveTitle(GlobalData.LibraryData.SelectedTitle);
        }

        private void Filtr_Click(object sender, RoutedEventArgs e)
        {
            GlobalData.LibraryData.titleBase.filter.Clear();
            if ((int)TypeBox.SelectedIndex == 4)
            {
                ResourcesData.SetBinding(DataGrid.ItemsSourceProperty, "titleBase.titles");
            }
            else
            {
                if ((int)TypeBox.SelectedIndex == (int)TitleType.Book)
                    GlobalData.LibraryData.titleBase.Filtr(TitleType.Book);
                else if ((int)TypeBox.SelectedIndex == (int)TitleType.Movie)
                    GlobalData.LibraryData.titleBase.Filtr(TitleType.Movie);
                else if ((int)TypeBox.SelectedIndex == (int)TitleType.Magazine)
                    GlobalData.LibraryData.titleBase.Filtr(TitleType.Magazine);
                else
                    GlobalData.LibraryData.titleBase.Filtr(TitleType.Thesis);
                ResourcesData.SetBinding(DataGrid.ItemsSourceProperty, "titleBase.filter");
            }
        }
    }
}
