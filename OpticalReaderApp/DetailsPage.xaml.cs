using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using OpticalReaderApp;
using OpticalReaderApp.Resources;

namespace DataBoundApp1
{
    public partial class DetailsPage : PhoneApplicationPage
    {
        // Constructor
        public DetailsPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        // When page is navigated to set data context to selected item in list
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (DataContext == null)
            {
                string selectedIndex = "";
                if (NavigationContext.QueryString.TryGetValue("selectedItem", out selectedIndex))
                {
                    int index = int.Parse(selectedIndex);
                    DataContext = App.ViewModel.Items[index];
                }
            }
            if (DetailHeader.Text == "Comwell")
            {
                DetailImage.Source = new BitmapImage(new Uri("http://media-cdn.tripadvisor.com/media/photo-s/02/a5/bb/65/comwell-roskilde.jpg"));
            }
            if (DetailHeader.Text == "Danhostel")
            {
                DetailImage.Source = new BitmapImage(new Uri("http://www.cleartrip.com/places/hotels//5995/599533/images/6933978_w.jpg"));
            }
            if (DetailHeader.Text == "Scandic")
            {
                DetailImage.Source = new BitmapImage(new Uri("http://www.kursuslex.dk/billeder/672_generelt_billede1__%7BCA0E2709-485E-4406-BD45-DA5FB524F951%7D_stor_.jpg"));
            }
            if (DetailHeader.Text == "Motel Wittrup")
            {
                DetailImage.Source = new BitmapImage(new Uri("http://www.visitvestegnen.dk/sites/default/files/styles/galleries_ratio/public/asp/visitvestegnen/hotel/wittrup-vaerelser-ext.jpg?itok=1q3nGXs5"));
            }
            if (DetailHeader.Text == "Hotel Viby Kro")
            {
                DetailImage.Source = new BitmapImage(new Uri("http://www.vibykro.dk/Billeder/Kroen.jpg"));
            }
            if (DetailHeader.Text == "Hotel Prindsen")
            {
                DetailImage.Source = new BitmapImage(new Uri("http://www.kulturarv.dk/1001fortaellinger/uploads/images/editions/prindsen-nat/690x_.jpg"));
            }
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}