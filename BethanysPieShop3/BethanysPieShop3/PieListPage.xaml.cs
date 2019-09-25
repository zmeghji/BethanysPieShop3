using BethanysPieShop3.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShop3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PieListPage : ContentPage
    {
        public ObservableCollection<Pie> Pies { get; set; }
        public PieListPage()
        {
            InitializeComponent();
            Pies = new ObservableCollection<Pie>
            {
                new Pie{
                    Id=1,
                    Name="Apple Pie",
                    Price=1.00,
                    InStock=true
                },
                new Pie{
                    Id=2,
                    Name="Cherry Pie",
                    Price=2.00,
                    InStock =true
                },
                new Pie{
                    Id=3,
                    Name="Pumpkin Pie",
                    Price=3.00
                }
            };
            PieListView.ItemsSource = Pies;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Pies.Add(new Pie { Id = 4, Name = "New Pie", Price = 4.00, InStock=true });
        }
    }
}