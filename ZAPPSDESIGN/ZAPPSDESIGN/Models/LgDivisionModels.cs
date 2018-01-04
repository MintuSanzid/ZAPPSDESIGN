using System;
using System.Collections.Generic;
using System.Text;

namespace ZAPPSDESIGN.Models
{
    public class LgDivisionModels
    {
        public int DivisionId { get; set; }
        public int? CountryId { get; set; }
    
        public string DivisionCode { get; set; }      
        public string DivisionName { get; set; }
        public string DivisonNameOther { get; set; }
        public bool? IsRemoved { get; set; }
    }
}
