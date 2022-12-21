using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONET.Models
{
    internal class Artist
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Birthday { get; set; }
        public string Gender { get; set; }
        public Artist(int id,string name, string surname, string birthday, string gender)
        {
            ID = id;
            Name = name;
            Surname = surname;
            Birthday = birthday;
            Gender = gender;
        }
    }
}