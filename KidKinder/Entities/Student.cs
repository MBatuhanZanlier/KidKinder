using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KidKinder.Entities
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string NameSurname { get; set; }
        public int BranchID { get; set; }
        public virtual Branch Branch { get; set; }



    }
}
