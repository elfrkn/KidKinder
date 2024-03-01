using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidKinder.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentNameSurname{ get; set; }
        public string Age{ get; set; }
        public int ClassRoomId { get; set; }
        public virtual ClassRoom ClassRoom { get; set; }
        public List<Parent> Parents { get; set; }
    }
}