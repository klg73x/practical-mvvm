using JoeCoffeeStore.StockManagement.App.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoeCoffeeStore.StockManagement.App
{
    public class ViewModelLocator
    {
        public static CoffeeOverviewViewModel CoffeeOverviewViewModel { get; } = new CoffeeOverviewViewModel();
        public static CoffeeDetailViewModel GetCoffeeDetailViewModel { get; } = new CoffeeDetailViewModel();
    }
}
