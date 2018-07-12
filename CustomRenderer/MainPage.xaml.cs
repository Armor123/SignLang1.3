using System;
using Xamarin.Forms;

namespace CustomRenderer
{
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}
        async void OnTakePhotoButtonClicked (object sender, EventArgs e)
		{
			await Navigation.PushAsync (new CameraPage ());
		}
        private async void go_to_About(object sender, EventArgs e)
        {

            await Navigation.PushModalAsync(new About());
        }

        private async void go_to_Help(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Help());
        }
    }
}

