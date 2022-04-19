using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Untitled.pages.poisk
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class poisk : ContentPage
    {
        public poisk()
        {
            InitializeComponent();
        }

        private void loginEntry_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new pages.Glavnoeocno());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new pages.poisk.poisk());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
           
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {

        }
    }
}