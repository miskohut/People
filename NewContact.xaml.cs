using People.Backend;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace People {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NewContact : Page {

        Person Person { get; set; }
        private BitmapImage contactImage { get; set; }

        public NewContact() {
            this.InitializeComponent();

            Person = new Person();
            Person.Phones.Add(new Phone());
        }

        private void AddPhoneButton_Click(object sender, RoutedEventArgs e) {
            Person.Phones.Add(new Phone());
        }

        private void RemoveNumberButton_Click(object sender, RoutedEventArgs e) {
            Phone phone = (Phone)((Button)sender).DataContext;
            Person.Phones.Remove(phone);
        }

        private void RemoveEmailButton_Click(object sender, RoutedEventArgs e) {
            Email email = (Email)((Button)sender).DataContext;
            Person.Emails.Remove(email);
        }

        private void AddEmailButton_Click(object sender, RoutedEventArgs e) {
            Person.Emails.Add(new Email());
        }

        private void RemoveAddressButton_Click(object sender, RoutedEventArgs e) {
            Address address = (Address)((Button)sender).DataContext;
            Person.Addresses.Remove(address);
        }

        private void AddAddressButton_Click(object sender, RoutedEventArgs e) {
            Person.Addresses.Add(new Address());
        }   

        private async void AddRingthoneButton_Click(object sender, RoutedEventArgs e) {
            FileOpenPicker filePicker = new FileOpenPicker();
            filePicker.SuggestedStartLocation = PickerLocationId.MusicLibrary;
            filePicker.ViewMode = PickerViewMode.List;

            filePicker.FileTypeFilter.Clear();
            filePicker.FileTypeFilter.Add(".mp3");
            filePicker.FileTypeFilter.Add(".wav");
            filePicker.FileTypeFilter.Add(".wma");

            StorageFile file = await filePicker.PickSingleFileAsync();

            if (file != null) {
                Person.RingthonePath = file.Path;
            }
        }

        private async void AddSMSthoneButton_Click(object sender, RoutedEventArgs e) {
            FileOpenPicker filePicker = new FileOpenPicker();
            filePicker.SuggestedStartLocation = PickerLocationId.MusicLibrary;
            filePicker.ViewMode = PickerViewMode.List;

            filePicker.FileTypeFilter.Clear();
            filePicker.FileTypeFilter.Add(".mp3");
            filePicker.FileTypeFilter.Add(".wav");
            filePicker.FileTypeFilter.Add(".wma");

            StorageFile file = await filePicker.PickSingleFileAsync();

            if (file != null) {
                Person.RingthonePath = file.Path;
            }
        }

        private void NameDetailsButton_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(NewContactDetails), Person);
        }

        private void SaveBar_Click(object sender, RoutedEventArgs e) {

        }

        private async void EllipseGrid_Tapped(object sender, TappedRoutedEventArgs e) {
            FileOpenPicker filePicker = new FileOpenPicker();
            filePicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            filePicker.ViewMode = PickerViewMode.Thumbnail;

            filePicker.FileTypeFilter.Clear();
            filePicker.FileTypeFilter.Add(".bmp");
            filePicker.FileTypeFilter.Add(".png");
            filePicker.FileTypeFilter.Add(".jpeg");
            filePicker.FileTypeFilter.Add(".jpg");

            StorageFile file = await filePicker.PickSingleFileAsync();

            if (file != null) {
                Person.PhotoPath = file.Path;
                using (IRandomAccessStream fileStream =
                    await file.OpenAsync(FileAccessMode.Read)) {
                    // Set the image source to the selected bitmap.
                    contactImage = new BitmapImage();

                    contactImage.SetSource(fileStream);
                    ImageSource.ImageSource = contactImage;

                    EllipseText.Visibility = Visibility.Collapsed;

                }
            }
        }



        protected override void OnNavigatedTo(NavigationEventArgs e) {
            if (e.Parameter is Person) {
                this.Person = (Person)e.Parameter;
            }

            NumbersListView.ItemsSource = this.Person.Phones;
            EmailsListView.ItemsSource = this.Person.Emails;
            AddressesListView.ItemsSource = this.Person.Addresses;

            base.OnNavigatedFrom(e);
        }
    }
}
