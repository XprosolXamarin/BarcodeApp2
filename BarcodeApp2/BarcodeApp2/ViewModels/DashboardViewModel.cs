using BarcodeApp2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace BarcodeApp2.ViewModels
{
    public class DashboardViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<MainCategoryModel> Category { get; set; } = new ObservableCollection<MainCategoryModel>();

        public DashboardViewModel()
        {
            Category.Add(new MainCategoryModel
            {
                Name = "Shampoos",
                Details= "Sunsilk",
                ImageUrl= "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQMCUkSK3ANkZaCNV5rymrJKW6J9ZcB3hTK0w&usqp=CAU"


            });
            Category.Add(new MainCategoryModel
            {
                Name = "Shampoos",
                Details = "Sunsilk",
                ImageUrl = "sunsilkshampoo.jpg"


            });
            Category.Add(new MainCategoryModel
            {
                Name = "Shampoos",
                Details = "Sunsilk",
                ImageUrl = "sunsilkshampoo.jpg"


            });
            Category.Add(new MainCategoryModel
            {
                Name = "Shampoos",
                Details = "Sunsilk",
                ImageUrl = "sunsilkshampoo.jpg"


            });
            Category.Add(new MainCategoryModel
            {
                Name = "Shampoos",
                Details = "Sunsilk",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQMCUkSK3ANkZaCNV5rymrJKW6J9ZcB3hTK0w&usqp=CAU"


            });
            Category.Add(new MainCategoryModel
            {
                Name = "Shampoos",
                Details = "Sunsilk",
                ImageUrl = "sunsilkshampoo.jpg"


            });
        }
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
