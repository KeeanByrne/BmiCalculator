using BmiCalc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiCalc.MVVM.ViewModel
{
    class MainViewModel : ObservableObject 
    {

        public RelayCommand HomeViewCommand { get; set; }

        public RelayCommand CalculatorViewCommand { get; set; }

        public HomeViewModel HomeVm { get; set; }

        public CalculatorViewModel CalculatorVm { get; set; }


        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set 
            {   _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVm = new HomeViewModel();
            CalculatorVm = new CalculatorViewModel();

            CurrentView = HomeVm;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVm;


            });

            CalculatorViewCommand = new RelayCommand(o =>
            {
                CurrentView = CalculatorVm;


            });
        }
    }
}
