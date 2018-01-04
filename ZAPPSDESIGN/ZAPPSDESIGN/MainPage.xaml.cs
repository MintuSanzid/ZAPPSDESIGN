using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZAPPSDESIGN.MenuItems;
using ZAPPSDESIGN.Views;

namespace ZAPPSDESIGN
{
	public partial class MainPage : MasterDetailPage
	{
        public List<MasterPageItem> menuList { get; set; }
        public MainPage()
		{
			InitializeComponent();
            menuList = new List<MasterPageItem>();
            //this are for android Icons you can download from android asset studio and include in Your Project Resources Folder
            // Creating our pages for menu navigation
            // Here you can define title for item, 
            // icon on the left side, and page that you want to open after selection
            var page1 = new MasterPageItem() { Title = "User Registration", Icon = "man.png", TargetType = typeof(Registration) };           
            var page3 = new MasterPageItem() { Title = "Login", Icon = "Icon.png", TargetType = typeof(View3)};          
            var page5 = new MasterPageItem() { Title = "Contact Us", Icon = "Icon.png", TargetType = typeof(Login)};
            var page4 = new MasterPageItem() { Title = "Users", Icon = "Icon.png", TargetType = typeof(View4)};
            //var page2 = new MasterPageItem() { Title = "Search", Icon = "search.png", TargetType = typeof(View2)};
            var page6 = new MasterPageItem() { Title = "List Of Users", Icon = "search.png", TargetType = typeof(UserListView)};
            var page7 = new MasterPageItem() { Title = "Grid", Icon = "search.png", TargetType = typeof(GridUI)};
            var page8 = new MasterPageItem() { Title = "Table", Icon = "search.png", TargetType = typeof(TableUI) };

            //Fot Ios icons
            //var page1 = new MasterPageItem() { Title = "FastDelivery", Icon = "ic_local_shipping.png", TargetType = typeof(View1) };
            //var page2 = new MasterPageItem() { Title = "Menus", Icon = "ic_restaurant.png", TargetType = typeof(View2) };
            //var page3 = new MasterPageItem() { Title = "Free Pizza", Icon = "ic_local_pizza.png", TargetType = typeof(View3) };
            //var page4 = new MasterPageItem() { Title = "Dining", Icon = "ic_local_dining.png", TargetType = typeof(View4) };
            //var page5 = new MasterPageItem() { Title = "Parking", Icon = "ic_local_parking.png", TargetType = typeof(View1) };
            //var page6 = new MasterPageItem() { Title = "LocateUs", Icon = "ic_my_location.png", TargetType = typeof(View2) };
            // Adding menu items to menuList
            menuList.Add(page1);
            menuList.Add(page3);
            menuList.Add(page5);
            menuList.Add(page4);
            menuList.Add(page6);
            menuList.Add(page7);
            menuList.Add(page8); 

            // Setting our list to be ItemSource for ListView in MainPage.xaml
            navigationDrawerList.ItemsSource = menuList;
            // Initial navigation, this can be used for our home page
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Login))); /*ViewMain*/           
            this.BindingContext = new
            {
                Header = "Bitopi Group",
                Image = "Icon.png",
                //Footer = "-------- Welcome To HotelPlaza -------"
                Footer = "Menu List"
            };
            IsPresented = true;
        }
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {
                var item = (MasterPageItem)e.SelectedItem;
                if (item.Title == "User Registration")
                {
                   // DisplayAlert("Important-Notification", "Do you want Play Baseball ?", "Yes", "No");
                    Type page = item.TargetType;
                    Detail = new NavigationPage((Page)Activator.CreateInstance(page));
                }
                else if (item.Title == "Search Blood")
                {
                    Type page = item.TargetType;
                    Detail = new NavigationPage((Page)Activator.CreateInstance(page));
                }
                else if (item.Title == "Login")
                {
                    Type page = item.TargetType;
                    Detail = new NavigationPage((Page)Activator.CreateInstance(page));
                }
                else if (item.Title == "Dining")
                {
                    Type page = item.TargetType;
                    Detail = new NavigationPage((Page)Activator.CreateInstance(page));
                }
                else if (item.Title == "Contact Us")
                {
                    Type page = item.TargetType;
                    Detail = new NavigationPage((Page)Activator.CreateInstance(page));
                }
                else if (item.Title == "List Of Users")
                {
                    Type page = item.TargetType;
                    Detail = new NavigationPage((Page)Activator.CreateInstance(page));
                }
                else if (item.Title == "Grid")
                {
                    Type page = item.TargetType;
                    Detail = new NavigationPage((Page)Activator.CreateInstance(page));
                }
                else if (item.Title == "Table")
                {
                    Type page = item.TargetType;
                    Detail = new NavigationPage((Page)Activator.CreateInstance(page));
                }
                IsPresented = false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
      
    }
}
