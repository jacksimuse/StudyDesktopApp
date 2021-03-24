using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestApp
{
    public class PersonList : ObservableCollection<Person>
    {
        public PersonList()
        {
            Add(new Person("Willa", "Cather"));
            Add(new Person("Isak", "Dinesen"));
            Add(new Person("Victor", "Hugo"));
        }
    }
}
