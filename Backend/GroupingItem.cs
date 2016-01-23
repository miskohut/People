using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Backend {
    class GroupingItem : List<Person>{ 
        public object Key { get; set; }
    }
}
