using People.Backend;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
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
        
        private ObservableCollection<GroupingItem> groupingItems {
            get; set;
        }

        public MainPage() {
            this.InitializeComponent();

            groupingItems = Person.createGrouping(GlobalData.Instance.Contacts);
            ContactsViewSource.Source = groupingItems;
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e) {
            ObservableCollection<Person> filteredContacts = new ObservableCollection<Person>(GlobalData.Instance.Contacts.Where(o => o.NameToBeDisplayed.Contains(SearchBox.Text)).ToList());
            ObservableCollection<GroupingItem> filteredGroups = Person.createGrouping(filteredContacts);

            groupingItems.Clear();
            foreach (var groupingItem in filteredGroups) {
                groupingItems.Add(groupingItem);
            }
        }

        private void NewAppBarButton_Click(object sender, RoutedEventArgs e) {
            if (MainPivot.SelectedIndex == 0) {
                Frame.Navigate(typeof(NewContact));
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e) {
            if (e.Parameter is Person) {
                GlobalData.Instance.Contacts.Add((Person)e.Parameter);
                groupingItems = Person.createGrouping(GlobalData.Instance.Contacts);
            }

            base.OnNavigatedTo(e);
        }
    }
}
