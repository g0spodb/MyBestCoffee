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
    /// Логика взаимодействия для CoffeeView.xaml
    /// </summary>
    public partial class CoffeeView : UserControl
    {
    //    public CoffeeView()
    //    {
    //        InitializeComponent();
    //    }

        public static Model.Coffee constProd;
    public CoffeeView(Coffee n) 
        {
            var currentRecipes = MyBestCoffeeEntities.GetContext().Coffee.ToList();
            this.DataContext = this;
            InitializeComponent();
            constProd = n;
            this.DataContext = constProd;
            tb_name.Text = n.Name;
            //tb_class.Text = n.Id_Class;
            //tb_recipe.Text = n.Recipe.Id;
            //tb_Instruction.Text = n.Instruction.Id;
            //tb_Complexity.Text = n.Complexity.Id;


        }
    }
}
