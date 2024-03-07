using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_02._03
{
    [Serializable]
    public class Aquapark
    {
        public List<Aqua> AquaList { get; set; } = new List<Aqua>();
    }
    [Serializable]
    public class Aqua
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public Aqua() { }
        public Aqua(string name, string location, int capacity)
        {
            this.Name = name;
            this.Location = location;
            this.Capacity = capacity;
        }
    }
}
