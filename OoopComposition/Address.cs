using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoopComposition
{
    public class Address
    {
        public int Id { get; set; }
        public List<Person> Persons { set; get; } = new();
    }
}
