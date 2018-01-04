using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using ZAPPSDESIGN.Models;
using ZAPPSDESIGN.Services;
namespace ZAPPSDESIGN.ViewModels
{
    public class CountryViewModel
    {
        private ObservableCollection<CountryModels> items;
        public ObservableCollection<CountryModels> Items
        {
            get { return items; }
            set
            {
                items = value;
            }
        }
        

        public CountryViewModel()
        {
            Items = new ObservableCollection<CountryModels>()
            {
            };
            // Web service call to update list with new values
            CountryServices.GetAllNewsAsync(list =>
            {
                foreach (CountryModels items in list) 
                    Items.Add(items);
            });
        }


       


        // int countriesSelectedIndex;
        //public int CountriesSelectedIndex
        //{
        //    get
        //    {
        //        return countriesSelectedIndex;
        //    }
        //    set
        //    {
        //        if (countriesSelectedIndex != value)
        //        {
        //            countriesSelectedIndex = value;
        //           // DisplayAlert("Hey!");
        //            // trigger some action to take such as updating other labels or fields
        //            //  OnPropertyChanged(nameof(CountriesSelectedIndex));
        //            //SelectedCountry = Countries[countriesSelectedIndex];
        //        }
        //    }





        //    }
    }
}
