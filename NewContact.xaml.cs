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

            NumbersListView.ItemsSource = Person.Phones;
            EmailsListView.ItemsSource = Person.Emails;
            AddressesListView.ItemsSource = Person.Addresses;
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
        }

        private void AddRingthoneButton_Click(object sender, RoutedEventArgs e) {
        }

        private void AddSMSthoneButton_Click(object sender, RoutedEventArgs e) {

        }

        private void NameDetailsButton_Click(object sender, RoutedEventArgs e) {
        }

        private void SaveBar_Click(object sender, RoutedEventArgs e) {

        }
    }
}
