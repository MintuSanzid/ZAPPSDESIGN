using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Net.Http.Headers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZAPPSDESIGN.Models;
using ZAPPSDESIGN.Services;
using ZAPPSDESIGN.ViewModels;
namespace ZAPPSDESIGN.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserListView : ContentPage
    {
        
        public UserListView()
        {
            InitializeComponent();
            BindingContext = new UserListViewModel();

        }

     
        private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {

            var product = e.Item as BldUserReg; 
            var vm = BindingContext as UserListViewModel;
            vm?.ShowOrHidePoducts(product);
        }

        



    }
}
