using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Untitled.pages.lic
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class licnai : ContentPage
    {
        public licnai()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
           
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
 Navigation.PushModalAsync(new pages.otzov.otzof());
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new pages.otzov.otzof());
        }
    }
}