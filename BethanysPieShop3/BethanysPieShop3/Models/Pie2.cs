using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BethanysPieShop3.Models
{
    public class Pie2 : INotifyPropertyChanged
    {
        private int _id;
        private string _name;
        private double _price;

        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                RaisePropertyChangedEvent(nameof(Id));
            }
        }
        public string Name { get => _name; set { _name = value; RaisePropertyChangedEvent(nameof(Name)); } }
        public double Price { get => _price;
            set { _price = value; RaisePropertyChangedEvent(nameof(Price)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChangedEvent(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
