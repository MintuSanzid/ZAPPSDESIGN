using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZAPPSDESIGN.Services;
using ZAPPSDESIGN.Models;
using ZAPPSDESIGN.ViewModels;

namespace ZAPPSDESIGN.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registration : ContentPage
    {
        LgDivisionsServices _services = new LgDivisionsServices();
        public Registration()
        {
            InitializeComponent();
            CountyLoad();
            DivisionLoad();
            DistrictLoad();
            ThanasLoad();
            UnionLoad();
            VillageLoad();
        }
        public void CountyLoad()
        {
            CountryViewModel vm;           
            Countries.BindingContext = new CountryViewModel();           
            Countries.SetBinding(Picker.ItemsSourceProperty, "Items");
            Countries.ItemDisplayBinding = new Binding("CountryName");
        }
        public void DivisionLoad()
        {
            LgDivisionsViewModel vmm;          
            Division.BindingContext = new LgDivisionsViewModel();          
            Division.SetBinding(Picker.ItemsSourceProperty, "ItemsDivision");
            Division.ItemDisplayBinding = new Binding("DivisionName");
        }
        public void DistrictLoad() 
        {
            LgDistrictViewModel vmmm;
            //this.BindingContext = vmm = new LgDivisionsViewModel();
            District.BindingContext = new LgDistrictViewModel();          
            District.SetBinding(Picker.ItemsSourceProperty, "ItemsDistrict");
            District.ItemDisplayBinding = new Binding("DistrictName");
        }
        public void ThanasLoad() 
        {
            LgThanasViewModel vmmmm;
            //this.BindingContext = vmm = new LgDivisionsViewModel();
            Thana.BindingContext = new LgThanasViewModel();
            Thana.SetBinding(Picker.ItemsSourceProperty, "ItemsThana");
            Thana.ItemDisplayBinding = new Binding("ThanaName"); 
        }
        public void UnionLoad()
        {
            LgUnionViewModel vmmmmm;
            //this.BindingContext = vmm = new LgDivisionsViewModel();
            Ward.BindingContext = new LgUnionViewModel();
            Ward.SetBinding(Picker.ItemsSourceProperty, "ItemsUnion");
            Ward.ItemDisplayBinding = new Binding("UnionName");
        }
        public void VillageLoad() 
        {
            LgVillagesViewModel vmmmmmm;
            //this.BindingContext = vmm = new LgDivisionsViewModel();
            Village.BindingContext = new LgVillagesViewModel();
            Village.SetBinding(Picker.ItemsSourceProperty, "ItemsVillage");
            Village.ItemDisplayBinding = new Binding("VillageName");
        }

        //private void OnModeChosen(object sender, EventArgs e)
        //{

        //  CountryModels country = ((CountryModels)(Countries.SelectedItem));// get the country object from  the picker
        //  // Division.ItemsSource = _services.GetRegions(country.CountryId); // call the function to get the regions for that country
        //    Division.ItemsSource = _services.GetRegions(country.CountryId);            
        //  Division.ItemDisplayBinding = new Binding("DivisionName");
        //    Division.SelectedIndex = 0; // not sure why I did this, I think to make sure an item was selected
        ////stackpicker2.IsVisible = true // make the stack layout visible with the 2nd picker
        ////Division.IsEnabled = true;
        //}
        async void Registration_clicked(object sender, System.EventArgs e)
        {
            //    BldUserRegViewModel obj = new BldUserRegViewModel();
            //     string userName= userName.Text.Trim();
            //     string UserAddress=obj.UserAddress;
            //     string UserPhoneNo=obj.UserPhoneNo;
            //     string UserEmail=obj.UserEmail;
            //     string LoginId=obj.LoginId;
            //     string Password=obj.Password;

            //    BldUserRegServices _Service = new BldUserRegServices();
            //    var isSuccess = await _Service.RegisterAsync(userName, UserAddress, UserPhoneNo, UserEmail, LoginId, Password);
            //    if (isSuccess == true)
            //    {
            //        obj.Message = "Sign up Successfully";
            //    }
            //    else
            //    {
            //        obj.Message = "NOt Sign up Successfully";
            //    }
            BldUserRegServices _Service = new BldUserRegServices();
            string msg = "Check The data!";
            BldUserRegViewModel model = new BldUserRegViewModel
            {
                userName = userName.Text.Trim(),
                UserAddress = UserAddress.Text.Trim(),
                UserPhoneNo = UserPhoneNo.Text.Trim(),
                UserEmail = UserEmail.Text.Trim(),
                LoginId = LoginId.Text.Trim(),
                Password = Password.Text.Trim()
            };
            var isSuccess = await _Service.RegisterAsync(model.userName, model.UserAddress, model.UserPhoneNo, model.UserEmail, model.LoginId, model.Password);
            if (isSuccess)
            {
                await DisplayAlert("Hey!", msg, "Ok");
            }
            else
            {
                await DisplayAlert("Hey!", msg, "Err");

            }
            // RefreshData();
        }
    }
}
