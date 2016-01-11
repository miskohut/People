using People.Backend;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace People {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page {

        private ObservableCollection<Person> Contacts;
        private ObservableCollection<GroupingItem> groupingItems = new ObservableCollection<GroupingItem>();

        public MainPage() {
            this.InitializeComponent();

            Contacts = new ObservableCollection<Person>();

            Person Luke = new Person();
            Luke.FirstName = "Luke";
            Luke.LastName = "Skywalker";
            Luke.SetNameToBeDisplayed(Luke.FirstName + " " + Luke.LastName);

            Contacts.Add(Luke);

            Luke = new Person();
            Luke.FirstName = "Luke";
            Luke.LastName = "Skywalker";
            Luke.SetNameToBeDisplayed(Luke.FirstName + " " + Luke.LastName);

            Contacts.Add(Luke);

            Luke = new Person();
            Luke.FirstName = "Luke";
            Luke.LastName = "Skywalker";
            Luke.SetNameToBeDisplayed(Luke.FirstName + " " + Luke.LastName);

            Contacts.Add(Luke);

            Luke = new Person();
            Luke.FirstName = "Luke";
            Luke.LastName = "Skywalker";
            Luke.SetNameToBeDisplayed(Luke.FirstName + " " + Luke.LastName);

            Contacts.Add(Luke);

            Person James = new Person();
            James.FirstName = "James";
            James.LastName = "Kirk";
            James.SetNameToBeDisplayed(James.FirstName + " " + James.LastName);

            Contacts.Add(James);

            Person Peter = new Person();
            Peter.FirstName = "Peter";
            Peter.LastName = "Quill";
            Peter.SetNameToBeDisplayed(Peter.FirstName + " " + Peter.LastName);

            Contacts.Add(Peter);

            //ContactsListView.ItemsSource = groupingItems;
            CollectionViewSource.Source = Person.createGrouping(Contacts);
        }
    }
}
