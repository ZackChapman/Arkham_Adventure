using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArkhamAdventure.Models
{
    public partial class Scenario
    {
        public Scenario()
        {
            //NavButtonsButtonId1Navigation = new HashSet<NavButtons>();
            //NavButtonsButtonId2Navigation = new HashSet<NavButtons>();
            //NavButtonsButtonId3Navigation = new HashSet<NavButtons>();
            //NavButtonsButtonId4Navigation = new HashSet<NavButtons>();
        }
        [Key]
        public int ScenarioId { get; set; }
        public string StoryText { get; set; }
        public int NavigationId { get; set; }
        [Column("ImageID")]
        public int ImageID {get; set;}
        

        public virtual NavButtons Navigation { get; set; }
        [ForeignKey(nameof(ImageID))]
        public virtual Images Images { get; set; }

        //public virtual ScenarioImages Images { get; set; }
       
    }
}
