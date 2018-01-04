using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZAPPSDESIGN.ViewModels;

namespace ZAPPSDESIGN.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListData : ContentPage
	{
		public ListData ()
		{
			InitializeComponent ();
            BindingContext = new ListDataViewModel(); 
        }
	}
}