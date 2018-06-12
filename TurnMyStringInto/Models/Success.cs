using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TurnMyStringInto.Models
{
    public class Success
    {
        public int Id { get; set; }

        [Required]
        public int Total { get; set; }
    }
}