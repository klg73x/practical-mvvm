using JoeCoffeeStore.StockManagement.App.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace JoeCoffeeStore.StockManagement.App.Services
{
    public class DialogService
    {
        Window coffeeDetailView = null;

        public void ShowDialog()
        {
            coffeeDetailView = new CoffeeDetailView();
            coffeeDetailView.ShowDialog();
        }

        public void CloseDialog()
        {
            if (coffeeDetailView != null)
            {
                coffeeDetailView.Close();
            }
        }
    }
}
