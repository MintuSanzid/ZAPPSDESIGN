using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ZAPPSDESIGN.Models;
using ZAPPSDESIGN.Services;

namespace ZAPPSDESIGN.ViewModels
{
    public class LgDistrictViewModel
    {
        private ObservableCollection<LgDistrictModels> items;
        public ObservableCollection<LgDistrictModels> ItemsDistrict 
        {
            get { return items; }
            set
            {
                items = value;
            }
        }

        public LgDistrictViewModel() 
        {
            ItemsDistrict = new ObservableCollection<LgDistrictModels>()
            {


            };
            // Web service call to update list with new values
            LgDistrictServices.GetAllNewsAsync(list =>
            {
                foreach (LgDistrictModels items in list)
                    ItemsDistrict.Add(items);
            });
        }

        
    }
}
