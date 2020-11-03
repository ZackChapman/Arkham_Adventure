using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArkhamAdventure.Models
{
    public partial class Player
    {
        [Key]
        public int PlayerId { get; set; }
        [ForeignKey("Scenario")]
        public int ScenarioId { get; set; }

        public virtual Scenario Scenario { get; set; }
    }
}
