using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Untitled.pages.novinco
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class skoro_v_prodage : ContentPage
    {
        public skoro_v_prodage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new pages.Glavnoeocno());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new pages.novinco.navvinki());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new pages.novinco.skoro_v_prodage());
        }
    }
}