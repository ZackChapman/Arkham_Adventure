using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArkhamAdventure.Models
{
    public partial class NavButtons
    {
        public NavButtons()
        {
            //Scenario = new HashSet<Scenario>();
        }
        [Key]
        public int NavigationId { get; set; }
        public int ButtonId1 { get; set; }
        public int? ButtonId2 { get; set; }
        public int? ButtonId3 { get; set; }
        public int? ButtonId4 { get; set; }

        //[NotMapped]
        //public virtual Scenario ButtonId1Navigation { get; set; }
        //[NotMapped]
        //public virtual Scenario ButtonId2Navigation { get; set; }
        //[NotMapped]
        //public virtual Scenario ButtonId3Navigation { get; set; }
        //[NotMapped]
        //public virtual Scenario ButtonId4Navigation { get; set; }
        [NotMapped]
        public virtual NavOptions NavOptions { get; set; }
        //public virtual ICollection<Scenario> Scenario { get; set; }
    }
}
