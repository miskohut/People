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

            Person person = new Person();
            person.FirstName = "Luke";
            person.LastName = "Skywalker";
            person.SetNameToBeDisplayed(person.FirstName + " " + person.LastName);
            
            Contacts.Add(person);

            person = new Person();
            person.FirstName = "Adam";
            person.LastName = "Sandler";
            person.SetNameToBeDisplayed(person.FirstName + " " + person.LastName);

            Contacts.Add(person);

            person = new Person();
            person.FirstName = "Doctor";
            person.LastName = "Who";
            person.SetNameToBeDisplayed(person.FirstName + " " + person.LastName);

            Contacts.Add(person);

            person = new Person();
            person.FirstName = "Frodo";
            person.LastName = "Baggins";
            person.SetNameToBeDisplayed(person.FirstName + " " + person.LastName);

            Contacts.Add(person);

            person = new Person();
            person.FirstName = "Fero";
            person.LastName = "Mikloško";
            person.SetNameToBeDisplayed(person.FirstName + " " + person.LastName);


            person = new Person();
            person.FirstName = "Alice";
            person.LastName = "In Woderland";
            person.SetNameToBeDisplayed(person.FirstName + " " + person.LastName);

            Contacts.Add(person);

            person = new Person();
            person.FirstName = "Legolas";
            person.SetNameToBeDisplayed(person.FirstName + " " + person.LastName);

            Contacts.Add(person);

            person = new Person();
            person.FirstName = "Daniel";
            person.LastName = "Craige";
            person.SetNameToBeDisplayed(person.FirstName + " " + person.LastName);

            Contacts.Add(person);

            CollectionViewSource.Source = Person.createGrouping(Contacts);
        }
    }
}
