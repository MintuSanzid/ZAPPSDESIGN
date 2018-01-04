using Plugin.AutoLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZAPPSDESIGN.Models;
using ZAPPSDESIGN.Services;

namespace ZAPPSDESIGN.Views
{

    public partial class Login : ContentPage
    {
        LoginDataServiceController dataService;
        List<LoginModel> items;
        public Login()
        {
            InitializeComponent();
            dataService = new LoginDataServiceController();
            //RefreshData();
        #if DEBUG
            entry_email.Text = "mabrouk@mahdhi.com";
            entry_password.Text = "password";
        #endif
        }


        //private void Connect_clicked(object sender, EventArgs e)
        //{

        //    string msg = "Please verify your login and your password!";
        //    if (entry_email.Text.ToLower() != "mabrouk@mahdhi.com")
        //    {
        //        DisplayAlert("Hey!", msg, "Ok");
        //        return;
        //    }

        //    if (entry_password.Text.ToLower() != "password")
        //    {
        //        DisplayAlert("Hey!", msg, "Ok");
        //        return;
        //    }

        //    // Test if user is already saved 

        //    if (CrossAutoLogin.Current.UserIsSaved == false)

        //    {

        //        CrossAutoLogin.Current.SaveUserInfos(entry_email.Text, entry_password.Text);

        //    }

        //    Navigation.PushModalAsync(new View3());

        //}

        async void Connect_clicked(object sender, System.EventArgs e) 
        {
            string msg = "Please verify your login and your password!";
            LoginModel newLoginModelItem = new LoginModel
            {
                entryEmail = entry_email.Text.Trim(),// txtTodoItem.Text.Trim(),
                entryPassword = entry_password.Text.Trim() //dpDueDate.Date.ToString("d")
            };
           var dbItems= await dataService.GetLoginModelAsync();//.AddTodoItemAsync(newItem);   
            //newLoginModelItem.entryEmail = dbIt

            if (entry_email.Text.ToLower() != "mabrouk@mahdhi.com")
            {
                await DisplayAlert("Hey!", msg, "Ok");
                return;
            }
            else if (entry_password.Text.ToLower() != "password")
            {
                await DisplayAlert("Hey!", msg, "Ok");
                return;
            }
            // Test if user is already saved 

            if (CrossAutoLogin.Current.UserIsSaved == false)

            {

                CrossAutoLogin.Current.SaveUserInfos(entry_email.Text, entry_password.Text);

            }

            Navigation.PushModalAsync(new View3());

            // RefreshData();
        }
        //public async void OnDone(object sender, EventArgs e)
        //{
        //    var mi = ((MenuItem)sender);
        //    TodoItem itemToUpdate = (TodoItem)mi.CommandParameter;
        //    itemToUpdate.isDone = true;
        //    int itemIndex = items.IndexOf(itemToUpdate);
        //    await dataService.UpdateTodoItemAsync(itemIndex, itemToUpdate);
        //    RefreshData();
        //}

        //public async void OnDelete(object sender, EventArgs e)
        //{
        //    var mi = ((MenuItem)sender);
        //    TodoItem itemToDelete = (TodoItem)mi.CommandParameter;
        //    int itemIndex = items.IndexOf(itemToDelete);
        //    await dataService.DeleteTodoItemAsync(itemIndex);
        //    RefreshData();
        //}

        //async void RefreshData()
        //{
        //    items = await dataService.GetTodoItemsAsync();
        //    todoList.ItemsSource = items.OrderBy(item => item.isDone).ThenBy(item => item.DueDate).ToList();
        //}
    }

}




























//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//using Xamarin.Forms;
//using Xamarin.Forms.Xaml;

//namespace ZAPPSDESIGN.Views
//{
//	[XamlCompilation(XamlCompilationOptions.Compile)]
//	public partial class Login : ContentPage 
//	{
//		public Login()
//		{
//			InitializeComponent ();
//            this.InitializeComponent();

//            // Define the binding context
//            this.BindingContext = this;

//            // Set the IsBusy property
//            this.IsBusy = false;

//            // Login button action
//            this.BtnLogin.Clicked += BtnLogin_Clicked;
//        }
//        private void BtnLogin_Clicked(object sender, EventArgs e)
//        {
//            this.IsBusy = true;
//        }
//    }
//}