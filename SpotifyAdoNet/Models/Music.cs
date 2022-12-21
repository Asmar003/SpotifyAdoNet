using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONET.Models
{
    internal class Music
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int CategoryId { get; set; }

        public Music(int id,string name, int duration, int categoryid)
        {
            ID = id; 
            Name = name;
            Duration = duration;
            CategoryId = categoryid;

        }
    }
}
