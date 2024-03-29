﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KidKinder.Entities
{
    public class Teacher
    {
      
        public int TeacherId { get; set; }
        public string NameSurname { get; set; }
        public string ImageUrl { get; set; }
        public int BranchID { get; set; } 
        public virtual  Branch Branch { get; set; }
    }
}