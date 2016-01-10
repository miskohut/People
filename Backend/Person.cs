using System;
using System.Collections.Generic;
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
        public String RingtonePath { get; set; }
        public String SMSTonePath { get; set; }

        public List<Phone> Phones { get; }
        public List<Email> Emails { get; }
        public List<Address> Addresses { get; }

        public Person() {
            Phones = new List<Phone>();
            Emails = new List<Email>();
            Addresses = new List<Address>();
        }

        public void SetNameToBeDisplayed(String name) {
            NameToBeDisplayed = name;
        }

    }
}
