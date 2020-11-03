using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ArkhamAdventure.Models
{
    public partial class NavOptions
    {
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        [Key]
        public int NavigationId { get; set; }

        //public virtual NavButtons Navigation { get; set; }
    }
}
