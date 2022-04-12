using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Untitled.pages.auyh_reg;

namespace Untitled.pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class main_page : ContentPage
    {
        public main_page()
        {
            InitializeComponent();
           
        }

        private void next_Clicked(object sender, EventArgs e)
        {
          Navigation.PushModalAsync(new auth_page());
        }
    }
}