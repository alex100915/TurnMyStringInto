using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TurnMyStringInto.Models
{
    public class Contents
    {
        public int Id { get; set; }

        [Required]
        public string Translation { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public string Translated { get; set; }
    }
}