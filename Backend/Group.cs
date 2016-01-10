using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Backend {
    class Group {

        String Name { get; set; }

        List<Person> People { get; }

        public Group() {
            People = new List<Person>();
        }

    }
}
