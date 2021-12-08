using ListViewDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewDemo.Models
{
    public class ProductModel
    {
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        public List<SubProduct> SubProducts { get; set; } = new List<SubProduct>();
    }


    public class SubProduct : BaseViewModel
    {
        public string ProductName { get; set; }
        private bool _isSelected;
        public bool IsSelected
        {
            get => _isSelected;
            set => SetProperty(ref _isSelected, value);
        }
    }
}
