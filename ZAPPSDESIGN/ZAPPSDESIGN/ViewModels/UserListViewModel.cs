using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ZAPPSDESIGN.Models;
using ZAPPSDESIGN.Services;

namespace ZAPPSDESIGN.ViewModels
{
    public class UserListViewModel
    {


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

        public UserListViewModel()
        {  
            Items = new ObservableCollection<BldUserReg>() {
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

