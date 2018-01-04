using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ZAPPSDESIGN.Models;
using ZAPPSDESIGN.Services;

namespace ZAPPSDESIGN.ViewModels
{
    public class LgVillagesViewModel
    {
        private ObservableCollection<LgVillagesModels> items;
        public ObservableCollection<LgVillagesModels> ItemsVillage 
        {
            get { return items; }
            set
            {
                items = value;
            }
        }

        public LgVillagesViewModel()
        {
            ItemsVillage = new ObservableCollection<LgVillagesModels>()
            {


            };
            // Web service call to update list with new values
            LgVillagesServices.GetAllNewsAsync(list =>
            {
                foreach (LgVillagesModels items in list)
                    ItemsVillage.Add(items);
            });
        }


    }
}
