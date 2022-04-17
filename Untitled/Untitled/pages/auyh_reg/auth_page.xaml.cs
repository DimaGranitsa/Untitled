using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Untitled.pages.auyh_reg
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class auth_page : ContentPage
    {
        public auth_page()
        {
            InitializeComponent();
        }

        private void BLogin_Clicked(object sender, EventArgs e)
        {
            
        }

        private void BRegistration_Clicked(object sender, EventArgs e)
        {
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
Navigation.PushModalAsync(new pages.Glavnoeocno());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
Navigation.PushModalAsync(new reg.reg());
        }
    }
}