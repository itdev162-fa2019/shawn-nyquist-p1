using System;
using System.Collections.Generic;
using System.Linq;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Persistence;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PoemsController : ControllerBase
    {
        private readonly DataContext context;

        public PoemsController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]

        public ActionResult<List<Poem>> Get()
        {
            return this.context.Poems.ToList();
        }
    }
}