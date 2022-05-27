using MyBestCoffee.MVVM.Model;
using System.Linq;
using System.Windows.Controls;

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
    }
}
