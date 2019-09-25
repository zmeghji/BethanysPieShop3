using BethanysPieShop3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShop3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CodeDataBindingExample : ContentPage
    {
        public CodeDataBindingExample()
        {
            InitializeComponent();
            var pie = new Pie
            {
                Name = "Apple Pie",
                Price = 1.00
            };
            var nameBinding = new Binding
            {
                Source = pie,
                Path = "Name"
            };
            Name.SetBinding(Entry.TextProperty, nameBinding);
            var priceBinding = new Binding
            {
                Source = pie,
                Path = "Price"
            };
            Price.SetBinding(Entry.TextProperty, priceBinding);
        }
    }
}