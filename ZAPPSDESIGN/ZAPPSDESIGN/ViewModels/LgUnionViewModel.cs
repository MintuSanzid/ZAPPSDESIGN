
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ZAPPSDESIGN.Models;
using ZAPPSDESIGN.Services;

namespace ZAPPSDESIGN.ViewModels
{
    public class LgUnionViewModel
    {
        private ObservableCollection<LgUnionModels> items;
        public ObservableCollection<LgUnionModels> ItemsUnion
        {
            get { return items; }
            set
            {
                items = value;
            }
        }

        public LgUnionViewModel()
        {
            ItemsUnion = new ObservableCollection<LgUnionModels>()
            {


            };
            // Web service call to update list with new values
            LgUnionServices.GetAllNewsAsync(list => 
            {
                foreach (LgUnionModels items in list)
                    ItemsUnion.Add(items);
            });
        }


    }
}
