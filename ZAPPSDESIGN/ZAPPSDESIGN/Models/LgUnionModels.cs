using System;
using System.Collections.Generic;
using System.Text;

namespace ZAPPSDESIGN.Models
{
    public class LgUnionModels
    {       
        public int UnionId { get; set; }        
        public string UnionCode { get; set; }
        public int ThanaId { get; set; }      
        public string UnionName { get; set; }     
        public string UnionNameOther { get; set; }
        public bool? IsRemoved { get; set; }
    }
}
