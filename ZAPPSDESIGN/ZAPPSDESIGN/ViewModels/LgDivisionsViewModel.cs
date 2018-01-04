using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ZAPPSDESIGN.Models;
using ZAPPSDESIGN.Services;

namespace ZAPPSDESIGN.ViewModels
{
    public class LgDivisionsViewModel
    {
        private ObservableCollection<LgDivisionModels> items;
        public ObservableCollection<LgDivisionModels> ItemsDivision
        {
            get { return items; }
            set
            {
                items = value;
            }
        }

        public  LgDivisionsViewModel()
        {
            ItemsDivision = new ObservableCollection<LgDivisionModels>()
            {


            };
            // Web service call to update list with new values
            LgDivisionsServices.GetAllNewsAsync(list =>
            {
                foreach (LgDivisionModels items in list)
                    ItemsDivision.Add(items);
            });
        }

    }
}
