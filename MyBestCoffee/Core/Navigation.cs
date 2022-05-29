using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace MyBestCoffee.Core
{
    class Navigation
    {
        public static NavigationService navigationService = new NavigationService(Navigate);
    }
}
