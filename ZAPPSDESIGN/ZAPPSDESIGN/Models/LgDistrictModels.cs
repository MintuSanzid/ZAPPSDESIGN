using System;
using System.Collections.Generic;
using System.Text;

namespace ZAPPSDESIGN.Models
{
   public class LgDistrictModels
    {
        public int DistrictId { get; set; }      
        public string DistrictCode { get; set; }
        public int DivisionId { get; set; }      
        public string DistrictName { get; set; }       
        public string DistrictNameOther { get; set; }
        public bool? IsRemoved { get; set; }
    }
}
