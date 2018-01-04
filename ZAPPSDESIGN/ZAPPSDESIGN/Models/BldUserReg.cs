using System;
using System.Collections.Generic;
using System.Text;

namespace ZAPPSDESIGN.Models
{
    public class BldUserReg
    {
        public int UserId { get; set; }
        public string userName { get; set; }
        public string UserAddress { get; set; }
        public string UserPhoneNo { get; set; }
        public string UserEmail { get; set; }
        public string LoginId { get; set; }
        public string Password { get; set; }
        public bool IsVisible { get; set; }
    }
}
