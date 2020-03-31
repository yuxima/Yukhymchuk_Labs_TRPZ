using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Reservations.User_Interface
{
    class ViewModel:INotifyPropertyChanged
    {
        IModel model;
        public ViewModel(IModel model)
        {
            this.model = model;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private List<string> products;
        public List<string> Products
        {
            get => model.GetProducts();
            set
            {
                products = value;
            }
        }
        private string product;
        public string Product
        {
            get
            {
                return product;
            }
            set
            {
                product = value;
            }
        }
        private List<string> shops;
        public List<string> Shops
        {
            get
            {
                return model.GetShops(product);
            }
            set
            {
                shops = value;
            }
        }
        private string shop;
        public string Shop 
        { 
            get
            {
                return shop;
            }
            set
            {
                shop = value;
            }
        }
        private int numberOfProducts;
        public int NumberOfProducts
        {
            get
            {
                return numberOfProducts;
            }
            set
            {
                numberOfProducts = value;
            }
        }
        private int numberOfReservation;
        public int NumberOfReservation
        {
            get
            {
                return numberOfReservation;
            }
            set
            {
                numberOfReservation = value;
            }
        }
        private RelayCommand getReservationCommand;
        public RelayCommand GetReservation
        {
            get
            {
                return getReservationCommand ?? (new RelayCommand(obj =>
                {
                    GetReservationCommand();
                }));
            }
        }

        public void GetReservationCommand()
        {
            model.CreateReservation(numberOfReservation, product, numberOfProducts, shop);
            OnPropertyChanged("NumberOfProducts");
            OnPropertyChanged("NumberOfReservations");
        }
        public void GetShopsCommand()
        {

        }
        
    }
}
