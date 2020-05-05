using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XfAdMob
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            AdmobControl admobControl = new AdmobControl()
            {
                AdUnitId = "ca-app-pub-3940256099942544/6300978111"
            };
            Label adLabel = new Label() { Text = "Ads will be displayed here!" };

            Content = new StackLayout()
            {
                Children = { adLabel, admobControl }
            };

            this.Title = "Admob Page";
        }
    }
}
