using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiposDeLayoutsPV.XamlViews;
using Xamarin.Forms;

namespace TiposDeLayoutsPV {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
            this.botonstack.Clicked += async (sender, args) => await Navigation.PushModalAsync(new StackLayoutView());
            this.botonscroll.Clicked += async (sender, args) => await Navigation.PushModalAsync(new ScrollViewPage());
            this.botonframe.Clicked += async (sender, args) => await Navigation.PushModalAsync(new FrameView());
            this.botonflex.Clicked += async (sender, args) => await Navigation.PushModalAsync(new FlexLayoutView());
            this.botonabsolute.Clicked += async (sender, args) => await Navigation.PushModalAsync(new AbsoluteLayoutView());
        }
    }
}
