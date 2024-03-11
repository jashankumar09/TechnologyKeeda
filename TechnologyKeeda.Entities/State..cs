using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnologyKeeda.Entities
{
    public class State
    {
        //State have multiple cities

        public int id { get; set; }
        public string Name { get; set; } = "Default state";

        public int CountryId {get; set; } //foreign key
                                          //Navigation property
        public Country Country { get; set; } = new();

        public ICollection<City> Cities { get; set; } = new HashSet<City>();

    }
}
