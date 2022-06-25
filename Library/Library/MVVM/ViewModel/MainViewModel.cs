using Library.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand TitleViewCommand { get; set; }
        public RelayCommand ReadersViewCommand { get; set; }
        public RelayCommand RentsViewCommand { get; set; }
        public RelayCommand ReaderAddViewCommand { get; set; }
        public RelayCommand TitleAddViewCommand { get; set; }
        public RelayCommand RentAddViewCommand { get; set; }
        public RelayCommand FinishRentViewCommand { get; set; }
        public TitleViewModel TitleVM { get; set; }
        public ReaderAddViewModel ReaderAddVM { get; set; }
        public TitleAddViewModel TitleAddVM { get; set; }
        public ReaderViewModel ReaderVM { get; set; }
        public RentsViewModel RentsVM { get; set; }
        public RentAddViewModel RentAddVM { get; set; }
        public FinishRentViewModel FinishRentVM { get; set; }
        private object _currentView;

        public  object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            TitleVM = new TitleViewModel();
            ReaderVM = new ReaderViewModel();
            RentsVM = new RentsViewModel();
            ReaderAddVM = new ReaderAddViewModel();
            TitleAddVM = new TitleAddViewModel();
            RentAddVM = new RentAddViewModel();
            FinishRentVM = new FinishRentViewModel();
            CurrentView = TitleVM;
            TitleViewCommand = new RelayCommand(o =>
            {
                CurrentView = TitleVM;
            });
            ReadersViewCommand = new RelayCommand(o =>
            {
                CurrentView = ReaderVM;
            });
            RentsViewCommand = new RelayCommand(o =>
            {
                CurrentView = RentsVM;
            });
            ReaderAddViewCommand = new RelayCommand(o =>
            {
                CurrentView = ReaderAddVM;
            });
            TitleAddViewCommand = new RelayCommand(o =>
            {
                CurrentView = TitleAddVM;
            });
            RentAddViewCommand = new RelayCommand(o =>
            {
                CurrentView = RentAddVM;
            });
            FinishRentViewCommand = new RelayCommand(o =>
            {
                CurrentView = FinishRentVM;
            });
        }
    }
}
