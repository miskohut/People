using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Backend {
    class GlobalData {

        public static readonly GlobalData Instance = new GlobalData();

        public ObservableCollection<Person> Contacts { get; set; } 

        private GlobalData() {
            Contacts = new ObservableCollection<Person>();
        }
    }
}
