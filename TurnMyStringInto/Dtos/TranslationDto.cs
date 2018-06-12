using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurnMyStringInto.Dtos
{
    public class TranslationDto
    {
        public int Id { get; set; }

        public SuccessDto Success { get; set; }

        public ContentsDto Contents { get; set; }
    }
}