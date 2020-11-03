using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryControlListBoxSelected
{
    [Serializable]
    public class Bus
    {
        public int Id { get; set; }
        public string Mark { get; set; }
        public int Number { get; set; }
        public int TimeOfWay { get; set; }
    }
}
