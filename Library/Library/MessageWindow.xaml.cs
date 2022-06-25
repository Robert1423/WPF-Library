using System.Windows;
using System.Windows.Input;

namespace Library
{
    /// <summary>
    /// Logika interakcji dla klasy MessageWindow.xaml
    /// </summary>
    public partial class MessageWindow : Window
    {
        public MessageWindow(string label, string message)
        {
            InitializeComponent();
            if (label != "Błąd!")
                Info.Content = label;
            MessageText.Text = message;
            MouseDown += Window_MouseDown;
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }
        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
