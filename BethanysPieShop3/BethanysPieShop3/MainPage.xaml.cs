using BethanysPieShop3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BethanysPieShop3
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public Pie2 Pie { get; set; }
        public MainPage()
        {
            InitializeComponent();
            Pie = new Pie2
            {
                Name = "Apple Pie",
                Price = 1.00
            };
            MainGrid.BindingContext = Pie;
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Pie.Name += "_updated";
            Pie.Price++;
        }
    }
}
