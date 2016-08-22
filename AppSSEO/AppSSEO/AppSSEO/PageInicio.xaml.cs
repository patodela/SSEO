using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AppSSEO
{
    public partial class PageInicio : ContentPage
    {
        public PageInicio()
        {
            InitializeComponent();
            BtnIr.Clicked += BtnIr_Clicked;
        }

        void BtnIr_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SearchEval());
        }
    }
}
