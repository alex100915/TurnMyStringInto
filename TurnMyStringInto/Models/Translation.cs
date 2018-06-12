using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TurnMyStringInto.Models
{
    public class Translation
    {
        public int Id { get; set; }

        [Required]
        public int SuccessId { get; set; }
        public Success Success { get; set; }

        [Required]
        public int ContentsId { get; set; }
        public Contents Contents { get; set; }
    }
}