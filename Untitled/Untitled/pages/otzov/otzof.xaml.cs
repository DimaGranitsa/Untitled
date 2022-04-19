using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Untitled.pages.otzov
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class otzof : ContentPage
    {
        public otzof()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new pages.otzov1.otzov1());
        }
    }
    
}