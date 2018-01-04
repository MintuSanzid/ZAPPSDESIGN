using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using ZAPPSDESIGN.Models;
using ZAPPSDESIGN.Services;

namespace ZAPPSDESIGN.ViewModels
{
    public class BldUserRegViewModel //: INotifyPropertyChanged 
    {
    
        public ObservableCollection<BldUserReg> Products { get; set; }
        BldUserRegServices _Service = new BldUserRegServices();
        public int UserId { get; set; }
        public string userName { get; set; }
        public string UserAddress { get; set; }
        public string UserPhoneNo { get; set; }
        public string UserEmail { get; set; }
        public string LoginId { get; set; }
        public string Password { get; set; }
        public string Message { get; set; }


        private BldUserReg _oldProduct;
        private ObservableCollection<BldUserReg> items;
        public ObservableCollection<BldUserReg> Items
        {
            get { return items; }
            set
            {
                items = value;
            }
        }

        public BldUserRegViewModel() 
        {
            Items = new ObservableCollection<BldUserReg>()
            {
                //new BldUserReg()
                //{
                //    UserId=1,
                //    userName = "1",
                //    UserEmail="sss"

                //},
                //  new BldUserReg()
                //{
                //    UserId=2,
                //    userName = "2",
                //    UserEmail="sss"
                //},

            };
            // Web service call to update list with new values
            MyHTTP.GetAllNewsAsync(list =>
            {
                foreach (BldUserReg item in list)
                    Items.Add(item);
            });
        }


        public void ShowOrHidePoducts(BldUserReg product)
        {
            if (_oldProduct == product)
            {
                // click twice on the same item will hide it
                product.IsVisible = !product.IsVisible;
                UpdateProducts(product);
            }
            else
            {
                if (_oldProduct != null)
                {
                    // hide previous selected item
                    _oldProduct.IsVisible = false;
                    UpdateProducts(_oldProduct);
                }
                // show selected item
                product.IsVisible = true;
                UpdateProducts(product);
            }

            _oldProduct = product;
        }

        private void UpdateProducts(BldUserReg product)
        {
            var index = Items.IndexOf(product);
            Items.Remove(product);
            Items.Insert(index, product);
        }
    }
}
