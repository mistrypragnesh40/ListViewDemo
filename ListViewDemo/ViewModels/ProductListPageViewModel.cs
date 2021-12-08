using ListViewDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ListViewDemo.ViewModels
{
    public class ProductListPageViewModel : BaseViewModel
    {
        #region Properties
        public ObservableCollection<ProductModel> Products { get; set; } = new ObservableCollection<ProductModel>();
        #endregion

        #region Constructor
        public ProductListPageViewModel()
        {
            Products.Add(new ProductModel
            {
                ProductName = "computer",
                ProductDesc = "Computer",
                SubProducts = new List<SubProduct>
                {
                   new SubProduct{ProductName="Sub Product 1"},
                   new SubProduct{ProductName="Sub Product 2"},
                   new SubProduct{ProductName="Sub Product 3"},
                }
            });

            Products.Add(new ProductModel
            {
                ProductName = "Laptop",
                ProductDesc = "Laptop",
                SubProducts = new List<SubProduct>
                {
                   new SubProduct{ProductName="Sub Product 1"},
                   new SubProduct{ProductName="Sub Product 2"},
                   new SubProduct{ProductName="Sub Product 3"},
                }
            });

            Products.Add(new ProductModel
            {
                ProductName = "Monitor",
                ProductDesc = "Monitor",
                SubProducts = new List<SubProduct>
                {
                   new SubProduct{ProductName="Sub Product 1"},
                   new SubProduct{ProductName="Sub Product 2"},
                   new SubProduct{ProductName="Sub Product 3"},
                }
            });
        }
        #endregion

        #region Commads
        public ICommand SubItemSelectedCommand => new Command<SubProduct>((subProduct) =>
         {
             subProduct.IsSelected = !subProduct.IsSelected;
         });
        #endregion
    }
}
