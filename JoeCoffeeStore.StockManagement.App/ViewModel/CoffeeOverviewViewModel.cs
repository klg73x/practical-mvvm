﻿using JoeCoffeeStore.StockManagement.App.Extensions;
using JoeCoffeeStore.StockManagement.App.Services;
using JoeCoffeeStore.StockManagement.Model;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace JoeCoffeeStore.StockManagement.App.ViewModel
{
    public class CoffeeOverviewViewModel : INotifyPropertyChanged
    {
        private CoffeeDataService coffeeDataService;
        private ObservableCollection<Coffee> coffees;
        public ObservableCollection<Coffee> Coffees
        {
            get
            {
                return coffees;
            }
            set
            {
                coffees = value;
                RaisePropertyChanged("Coffees");
            }
        }

        private Coffee _selectedCoffee;

        public Coffee SelectedCoffee
        {
            get
            {
                return _selectedCoffee;
            }
            set
            {
                _selectedCoffee = value;
                RaisePropertyChanged("SelectedCoffee");
            }
        }

        public CoffeeOverviewViewModel()
        {
            coffeeDataService = new CoffeeDataService();
            LoadData();
        }

        private void LoadData()
        {
            Coffees = coffeeDataService.GetAllCoffees().ToObservableCollection(); //This makes the collection observable. the helper is in the extensions folder
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}