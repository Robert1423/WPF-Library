using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace Library.Core
{
    class ObservableObject : INotifyPropertyChanged
    {
        //Zarządzanie właściwościami
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            //Sprawdza czy właściwość się zmieniła, jeżeli tak to wywołuje zdarzenie
        }
    }
}
