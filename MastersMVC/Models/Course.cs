using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MastersMVC.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public University University { get; set; }
        public string WebsiteLink { get; set; }
        public string Description { get; set; }
        public decimal Fees { get; set; }
        [DataType(DataType.Date)]
        public DateTime ApplicationDueDay { get; set; }
    }

    public class MastersDBContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public object Masters { get; internal set; }
    }
}