using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidKinder.Entities
{
    public class Parent
    {
        public int ParentId { get; set; }
        public string ParentNameSurname { get; set; }
        public string Phone { get; set; }
        public int StudentId { get; set; }

        public virtual Student Student { get; set; }
    }
}