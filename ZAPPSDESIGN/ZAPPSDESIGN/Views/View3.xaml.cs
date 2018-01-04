using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.AutoLogin;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ZAPPSDESIGN.Views
{
    // [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class View3 : ContentPage 
    {
        public View3() 
        {
            InitializeComponent();
            label_home.Text = $"Welcome! the saved mail is : {CrossAutoLogin.Current.UserEmail}";
        }
        private void Disconnect_clicked(object sender, EventArgs e)
        {
            CrossAutoLogin.Current.DeleteUserInfos();
            Navigation.PopModalAsync();
        }
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
//	public partial class View3 : ContentPage
//	{
//		public View3 ()
//		{
//			InitializeComponent ();
//		}
//	}
//}
