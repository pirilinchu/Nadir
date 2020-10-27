using SkeletonExample.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace SkeletonExample.Pages
{
    public partial class Page1 : BasePage
    {
        public Page1()
        {
            InitializeComponent();
            this.BindingContext = new Page1ViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }


    }
}
