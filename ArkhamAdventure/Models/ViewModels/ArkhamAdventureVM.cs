using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArkhamAdventure.Models.ViewModels
{
    public class ArkhamAdventureVM
    {
    
        public int ScenarioId { get; set; }
        public string StoryText { get; set; }
        public int NavigationId { get; set; }
        public int ButtonId1 { get; set; }
        public int? ButtonId2 { get; set; }
        public int? ButtonId3 { get; set; }
        public int? ButtonId4 { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public int ImageId { get; set; }
        public byte[] Image { get; set; }
    }
}
