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
    public partial class ViewToViewBindingExample : ContentPage
    {
        public ViewToViewBindingExample()
        {
            InitializeComponent();
            var pie = new Pie
            {
                Name = "Apple Pie",
                Price = 1.00
            };
            MainGrid.BindingContext = pie;
        }
    }
}