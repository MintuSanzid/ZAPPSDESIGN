using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ZAPPSDESIGN.Models;
using ZAPPSDESIGN.Services;

namespace ZAPPSDESIGN.ViewModels
{
   public class CarsViewModel
    {
        private BldUserReg _oldProduct;
        // We are using ObservableCollection because:
        // When an object is added to or removed from an observable collection, the UI is automatically updated.
        private ObservableCollection<BldUserReg> items;
        public ObservableCollection<BldUserReg> Items
        {
            get { return items; }
            set
            {
                items = value;
            }
        }

        public CarsViewModel()
        {

            // Here you can have your data form db or something else,
            // some data that you already have to put in the list
            Items = new ObservableCollection<BldUserReg>() {
                new BldUserReg()
                {
                    userName = "1"
                   
                },
                  new BldUserReg()
                {
                    userName = "2"
                },

            };

            // Web service call to update list with new values
            MyHTTP.GetAllNewsAsync(list =>
            {
                foreach (BldUserReg item in list)
                    Items.Add(item);
            });
        }

      
    }
}
