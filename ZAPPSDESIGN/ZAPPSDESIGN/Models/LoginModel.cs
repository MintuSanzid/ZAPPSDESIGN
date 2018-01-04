using System;
using System.Collections.Generic;
using System.Text;

namespace ZAPPSDESIGN.Models
{
    public class LoginModel
    { 
        public string entryEmail { get; set; }
        public string entryPassword { get; set; } 
        public bool isActive { get; set; } 
    }
}
