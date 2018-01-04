using System;
using System.Collections.Generic;
using System.Text;

namespace ZAPPSDESIGN.Models
{
    public class LgVillagesModels
    {
       
        public int VillageId { get; set; }
        public string VillageCode { get; set; }
        public int UnionId { get; set; }
        public string VillageName { get; set; }
        public string VillageNameOther { get; set; }
        public bool? IsRemoved { get; set; }
    }
}
