using People.Backend;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace People {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NewContactDetails : Page {

        private Person Person { get; set; }

        public NewContactDetails() {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e) {
            if (e.Parameter is Person) {
                this.Person = (Person)e.Parameter;
            }
            else {
                this.Person = new Person();
            }

            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested += OnHardwareButtonsBackPressed;

            base.OnNavigatedTo(e);
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e) {

        }

        private void AppBarButton_Click_1(object sender, RoutedEventArgs e) {

        }

        private void OnHardwareButtonsBackPressed(object sender, BackRequestedEventArgs e) {
            // This is the missing line!
            Frame.Navigate(typeof(NewContact), Person);
        }
    }
}
