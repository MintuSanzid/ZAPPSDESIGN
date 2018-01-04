using System;
using System.Collections.Generic;
using System.Text;

namespace ZAPPSDESIGN.Models
{
   public class LgThanasModels
    {
        
        public int ThanaId { get; set; }     
        public string ThanaCode { get; set; }
        public int DistrictId { get; set; }       
        public string ThanaName { get; set; }      
        public string ThanaNameOther { get; set; }
        public bool? IsRemoved { get; set; }

    }
}
