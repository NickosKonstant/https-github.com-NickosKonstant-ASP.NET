using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MastersMVC.Models
{
    public class University
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public ICollection<Course> Coursies { get; set; }
    }
}

