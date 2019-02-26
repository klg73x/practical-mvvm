using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoeCoffeeStore.StockManagement.Model
{
    public class Coffee : INotifyPropertyChanged
    {
        private int coffeeId;
        public int CoffeeId
        {
            get { return coffeeId; }
            set
            {
                coffeeId = value;
                RaisePropertyChanged("CoffeeId");
            }
        }

        private string coffeeName;
        public string CoffeeName
        {
            get
            {
                return coffeeName;
            }
            set
            {
                coffeeName = value;
                RaisePropertyChanged("CoffeeName");
            }
        }

        private int price;
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                RaisePropertyChanged("Price");
            }
        }

        public string Description
        {
            get;
            set;
        }

        public Country OriginCountry
        {
            get;
            set;
        }

        public bool InStock
        {
            get;
            set;
        }

        public int AmountInStock 
        { 
            get; 
            set; 
        }

        public DateTime FirstAddedToStockDate
        {
            get;
            set;
        }

        public int ImageId
        {
            get;
            set;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
