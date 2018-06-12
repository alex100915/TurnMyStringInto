using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TurnMyStringInto.Dtos;
using TurnMyStringInto.Models;

namespace TurnMyStringInto.Controllers.API
{
    public class TranslationsController : ApiController
    {
        ApplicationDbContext _context;

        public TranslationsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpPost]
        public IHttpActionResult CreateNewTranslation(TranslationDto translationDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var translation = Mapper.Map<TranslationDto, Translation>(translationDto);
            _context.Translations.Add(translation);
            _context.SaveChanges();

            return Created(new Uri(Request.RequestUri + "/" + translation.Id), translationDto);
        }
    }
}
