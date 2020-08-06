using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dcoreact.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommentaryController: ControllerBase
    {
        private static ILogger<CommentaryController> _logger;

        public CommentaryController(ILogger<CommentaryController> logger)
        {
            _logger = logger;   
        }

        [HttpGet]
        public IEnumerable<Commentary> Get()
        {
            var list = new List<Commentary>();
            var c = new Commentary();
            c.TimeStamp = DateTime.Now;
            c.Comment = "So long, and thanks for the fish!";
            list.Add(c);
            return list;
        }
    }
}