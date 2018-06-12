using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TurnMyStringInto.Models
{
    public class Error
    {
        public int Id { get; set; }

        [Required]
        public int Code { get; set; }

        [Required]
        public string Message { get; set; }
    }
}