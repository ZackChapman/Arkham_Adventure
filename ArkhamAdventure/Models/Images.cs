using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArkhamAdventure.Models
{
    public partial class Images
    {
        [Key]
        public int ImageID { get; set; }
        public byte[] Image { get; set; }
        [NotMapped]
        public string ImageDataUrl { get; set; }
    }
}
