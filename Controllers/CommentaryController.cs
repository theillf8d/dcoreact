using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            c.TimeStamp = DateTime.Now.AddDays(-2);
            c.Comment = "So long, and thanks for the fish!";
            list.Add(c);
            return list.ToArray();
        }
    }
}