using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurnMyStringInto.Dtos
{
    public class ContentsDto
    {
        public int Id { get; set; }

        public string Translation { get; set; }

        public string Text { get; set; }

        public string Translated { get; set; }
    }
}