
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ZAPPSDESIGN.Models;
using ZAPPSDESIGN.Services;

namespace ZAPPSDESIGN.ViewModels
{
    public class LgThanasViewModel 
    {
        private ObservableCollection<LgThanasModels> items;
        public ObservableCollection<LgThanasModels> ItemsThana
        {
            get { return items; }
            set
            {
                items = value;
            }
        }

        public LgThanasViewModel() 
        {
            ItemsThana = new ObservableCollection<LgThanasModels>()
            {


            };
            // Web service call to update list with new values
            LgThanasServices.GetAllNewsAsync(list =>
            {
                foreach (LgThanasModels items in list)
                    ItemsThana.Add(items);
            });
        }

    }
}
