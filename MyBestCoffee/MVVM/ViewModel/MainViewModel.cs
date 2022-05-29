using MyBestCoffee.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBestCoffee.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand RecipesViewCommand { get; set; }

        public RelayCommand FavoriteViewCommand { get; set; }

        public RelayCommand CoffeeViewCommand { get; set; }



        public RecipesViewModel RecipesVM { get; set; }

        public FavoriteViewModel FavoriteVM { get; set; }

        public CoffeeViewModel CoffeeVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            RecipesVM = new RecipesViewModel();

            FavoriteVM = new FavoriteViewModel();

            CoffeeVM = new CoffeeViewModel();
            CurrentView = RecipesVM;
            RecipesViewCommand = new RelayCommand(o =>
            {
                CurrentView = RecipesVM;
            });
            FavoriteViewCommand = new RelayCommand(o =>
            {
                CurrentView = FavoriteVM;
            });
            CoffeeViewCommand = new RelayCommand(o =>
            {
                CurrentView = CoffeeVM;
            }); 
        }
    }
}
