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
    public class ErrorsController : ApiController
    {
        ApplicationDbContext _context;

        public ErrorsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpPost]
        public IHttpActionResult CreateNewTranslation(ErrorDto errorDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var error = Mapper.Map<ErrorDto, Error>(errorDto);
            _context.Errors.Add(error);
            _context.SaveChanges();

            return Created(new Uri(Request.RequestUri + "/" + error.Id), errorDto);
        }
    }
}
