using MyBestCoffee.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace MyBestCoffee.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для CoffeePage.xaml
    /// </summary>
    public partial class CoffeePage : Page
    {
        public static Model.Coffee constProd;
        public CoffeePage(Coffee n)
        {
            var currentRecipes = MyBestCoffeeEntities.GetContext().Coffee.ToList();
            this.DataContext = this;
            InitializeComponent();
            constProd = n;
            this.DataContext = constProd;
            tb_name.Text = n.Name;
        }
    }
}
