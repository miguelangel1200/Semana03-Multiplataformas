using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio01
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //StackLayoutDemo = new StackLayoutDemo();
            MainPage = new GridCode();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
