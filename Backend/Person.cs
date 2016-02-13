using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Backend {
    class Person {

        public String FirstName { get; set; }
        public String MiddleName { get; set; }
        public String LastName { get; set; }

        public String NameToBeDisplayed { get; set; }

        public String Title { get; set; }
        public String Suffix { get; set; }

        public DateTime Birthday { get; set; }

        public String PhotoPath { get; set; }
        public String RingthonePath { get; set; }
        public String SMSThonePath { get; set; }

        public ObservableCollection<Phone> Phones { get; }
        public ObservableCollection<Email> Emails { get; }
        public ObservableCollection<Address> Addresses { get; }

        public Person() {
            Phones = new ObservableCollection<Phone>();
            Emails = new ObservableCollection<Email>();
            Addresses = new ObservableCollection<Address>();
        }

        public void SetNameToBeDisplayed(String name) {
            NameToBeDisplayed = name;
        }

        public static ObservableCollection<GroupingItem> createGrouping(ObservableCollection<Person> contacts) {

            ObservableCollection<GroupingItem> groupingItems = new ObservableCollection<GroupingItem>();

            char[] Characters = contacts.Select(o => o.NameToBeDisplayed[0]).Distinct().ToArray().OrderBy(c => c).ToArray();

            foreach (char character in Characters) {
                GroupingItem groupingItem = new GroupingItem();
                groupingItem.Key = character;

                groupingItem.AddRange(contacts.Where(o => o.NameToBeDisplayed[0] == character).OrderBy(o => o.NameToBeDisplayed).ToList());
                groupingItems.Add(groupingItem);
            }

            return groupingItems;
        }
    }
}
