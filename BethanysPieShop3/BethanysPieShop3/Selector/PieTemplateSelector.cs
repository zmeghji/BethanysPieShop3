using BethanysPieShop3.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BethanysPieShop3.Selector
{
    public class PieTemplateSelector : DataTemplateSelector
    {
        public DataTemplate RegularPieTemplate { get; set; }
        public DataTemplate NotInStockTemplate { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var pie = (Pie)item;
            if (pie.InStock)
            {
                return RegularPieTemplate;
            }
            else { return NotInStockTemplate; }
        }
    }
}
