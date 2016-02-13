using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Backend {
    class Email {

        public String E_mail { get; set; }
        public Type EmailType { get; set; }

        public  List<Type> EmailTypes { get; }

        public Email() {
            EmailTypes = new List<Type>();

            EmailTypes.Add(new Type() { ContactType = "Home" });
            EmailTypes.Add(new Type() { ContactType = "Work" });
            EmailTypes.Add(new Type() { ContactType = "School" });
            EmailTypes.Add(new Type() { ContactType = "Friends" });
            EmailTypes.Add(new Type() { ContactType = "Others" });
        }
    }
}
