using MyBestCoffee.MVVM.Model;
using System.Linq;
using System.Windows.Controls;
using MyBestCoffee;
using System.Windows.Navigation;
using System.Windows;
using MyBestCoffee.Core;
using MyBestCoffee.MVVM.View;
using MyBestCoffee.MVVM.ViewModel;

namespace MyBestCoffee.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для RecipesView.xaml
    /// </summary>
    public partial class RecipesView : UserControl
    {
        public RecipesView()
        {
            InitializeComponent();
            var currentRecipes = MyBestCoffeeEntities.GetContext().Coffee.ToList();
            LViewRecipes.ItemsSource = currentRecipes;
        }

        private void LViewRecipes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LViewRecipes.SelectedItem != null)
            {
                var n = ((sender as ListView).SelectedItem as Coffee);
                //Command = "{Binding RecipesViewCommand}"
                bool v = NavigationService.Navigate(new CoffeeView(n));
                //CoffeeViewCommand = new RelayCommand(RelayCommand);
            }
            else MessageBox.Show("Выберите блюдо");
        }
    }
}
