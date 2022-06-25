using Library.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Logika interakcji dla klasy TitleAddView.xaml
    /// </summary>
    public partial class TitleAddView : UserControl
    {
        public  string authorFromBox { get; set; }
        public  string titleFromBox { get; set; }
        public  string quantityFromBox { get; set; }
        public int typeFromBox { get; set; }
        public DateTime dateFromBox { get; set; }
        public TitleAddView()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        private void QuantityBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //Wymuszenie na textbox przyjmowania tylko cyfr
            Regex regex = new Regex("[^0-9]+"); //Użycie wyrażenia regularnego, jeżeli znak między 0 - 9 to przyjmuje
            e.Handled = regex.IsMatch(e.Text);
        }

        private void AddTitleBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(titleFromBox) && !string.IsNullOrEmpty(quantityFromBox))
            {
                int idCheck = GlobalData.LibraryData.titleBase.CheckAvalaibleID();
                dateFromBox = ChooseDate.SelectedDate.Value;
                int q = int.Parse(quantityFromBox);
                if (typeBox.SelectedIndex == (int)TitleType.Book)
                {
                    if (idCheck >= 0)
                    {
                        Book title = new Book(titleFromBox, authorFromBox, idCheck + 1, q, dateFromBox.Year);
                        GlobalData.LibraryData.titleBase.Insert(title, idCheck);
                    }
                    else
                    {
                        Book title = new Book(titleFromBox, authorFromBox, GlobalData.LibraryData.titleBase.Size() + 1, q, dateFromBox.Year);
                        GlobalData.LibraryData.titleBase.Add(title);
                    }
                }
                else if (typeBox.SelectedIndex == (int)TitleType.Movie)
                {
                    if (idCheck >= 0)
                    {
                        Movie title = new Movie(titleFromBox, authorFromBox, idCheck + 1, dateFromBox.Year, q);
                        GlobalData.LibraryData.titleBase.Insert(title, idCheck);
                    }
                    else
                    {
                        Movie title = new Movie(titleFromBox, authorFromBox, GlobalData.LibraryData.titleBase.Size() + 1, dateFromBox.Year, q);
                        GlobalData.LibraryData.titleBase.Add(title);
                    }
                }
                else if (typeBox.SelectedIndex == (int)TitleType.Magazine)
                {
                    if (idCheck >= 0)
                    {
                        Magazine title = new Magazine(titleFromBox, idCheck + 1, q, dateFromBox);
                        GlobalData.LibraryData.titleBase.Insert(title, idCheck);
                    }
                    else
                    {
                        Magazine title = new Magazine(titleFromBox, GlobalData.LibraryData.titleBase.Size() + 1, q, dateFromBox);
                        GlobalData.LibraryData.titleBase.Add(title);
                    }
                }
                else if (typeBox.SelectedIndex == (int)TitleType.Thesis)
                {
                    if (idCheck >= 0)
                    {
                        Thesis title = new Thesis(titleFromBox, authorFromBox, idCheck + 1, q, dateFromBox);
                        GlobalData.LibraryData.titleBase.Insert(title, idCheck);
                    }
                    else
                    {
                        Thesis title = new Thesis(titleFromBox, authorFromBox, GlobalData.LibraryData.titleBase.Size() + 1, q, dateFromBox);
                        GlobalData.LibraryData.titleBase.Add(title);
                    }
                }
                else
                {
                    MessageWindow message = new MessageWindow("Błąd!","Błędny typ zasobu!\nNie można utworzyć");
                    message.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    message.ShowDialog();
                }
            }
            else
            {
                MessageWindow message = new MessageWindow("Błąd!","Wprowadzono błędne dane!\nNie można utworzyć");
                message.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                message.ShowDialog();
            }
            authorFromBox = string.Empty;
            titleFromBox = string.Empty;
            quantityFromBox = string.Empty;
            authorBox.Text = string.Empty;
            titleBox.Text = string.Empty;
            quantityBox.Text = string.Empty;
            ChooseDate.Text = string.Empty;
            typeBox.SelectedIndex = 4;
        }

        private void CancelTitleBtn_Click(object sender, RoutedEventArgs e)
        {
            authorFromBox = string.Empty;
            titleFromBox = string.Empty;
            quantityFromBox = string.Empty;
            authorBox.Text = string.Empty;
            titleBox.Text = string.Empty;
            quantityBox.Text = string.Empty;
            ChooseDate.Text = string.Empty;
            typeBox.SelectedIndex = 4;
        }
    }
}
