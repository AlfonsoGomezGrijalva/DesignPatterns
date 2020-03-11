using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Structural.Composite;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DesignPatterns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompositeController : ControllerBase
    {
        private readonly ILogger<CompositeController> _logger;

        public CompositeController(ILogger<CompositeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                int goldForKill = 1023;
                sb.AppendLine($"You have killed the Giant Monster and gained {goldForKill} gold!");

                var joe = new Person { Name = "Joe" };
                var jake = new Person { Name = "Jake" };
                var emily = new Person { Name = "Emily" };
                var sophia = new Person { Name = "Sophia" };
                var brian = new Person { Name = "Brian" };
                var oldBob = new Person { Name = "Old Bob" };
                var newBob = new Person { Name = "New Bob" };
                var bobs = new Group { Members = { oldBob, newBob } };
                var developers = new Group { Name = "Developers", Members = { joe, jake, emily, bobs } };

                var parties = new Group { Members = { developers, sophia, brian } };

                parties.Gold += goldForKill;
                sb.Append(parties.Stats());

                return Ok(sb.ToString());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }
    }
}
