using System;
using System.Collections.Generic;
using System.Text;

namespace ZAPPSDESIGN.Models
{
    public class CountryModels
    {
        public int CountryId { get; set; }        
        public string CountryCode { get; set; }       
        public string CountryName { get; set; }
        public string CountryShortCode { get; set; }
        public string IsoCode { get; set; }
        public bool Status { get; set; }
        public bool IsRemoved { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int CreateBy { get; set; }
    }
}
