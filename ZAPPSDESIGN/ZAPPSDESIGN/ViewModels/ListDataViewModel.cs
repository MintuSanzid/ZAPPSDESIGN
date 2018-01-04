using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using ZAPPSDESIGN.Models;
using ZAPPSDESIGN.Services;

namespace ZAPPSDESIGN.ViewModels
{
    public class ListDataViewModel : INotifyPropertyChanged
    {
    
        private ObservableCollection<BldUserReg> items;

        public event PropertyChangedEventHandler PropertyChanged;
      

        public ObservableCollection<BldUserReg> Items
        {
            get { return items; }
            set
            {

                items = value;
            }
        }


        public ListDataViewModel() 
        {
            MyHTTPService.GetAllNewsAsync(list =>
            {
                foreach (BldUserReg item in list)
                    Items.Add(item);
            });
            // Here you can have your data form db or something else,
            // some data that you already have to put in the list

            //Items = new ObservableCollection<BldUserReg>() {
            //    new BldUserReg()
            //    {
            //        userName = "Min"

            //    },
            //      new BldUserReg()
            //    {
            //         userName = "Mintu"
            //    },

            //};
            // Web service call to update list with new values





            //BldUserRegServices _service = new BldUserRegServices();
            //var response = _service.getEmployeesAsync(List =>
            //{
            //    foreach (BldUserReg item in List)
            //        Items.Add(item);
            //});

        }
    }
}
