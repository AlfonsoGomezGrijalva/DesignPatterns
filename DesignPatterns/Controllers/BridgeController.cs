using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Bridge.Formatter;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace DesignPatterns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BridgeController : ControllerBase
    {
        private readonly ILogger<BridgeController> _logger;

        public BridgeController(ILogger<BridgeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                List<Manuscript> documents = new List<Manuscript>();
                var formatter = new StandardFormatter();

                var faq = new FAQ(formatter);
                faq.Title = "The Bridge Pattern FAQ";
                faq.Questions.Add("What is it?", "A design pattern");
                faq.Questions.Add("When do we use it?", "When you need to separate an abstraction from an implementation.");
                documents.Add(faq);

                var book = new Book(formatter)
                {
                    Title = "Lots of Patterns",
                    Author = "Alfonso Gomez",
                    Text = "Blah blah blah..."
                };
                documents.Add(book);

                var paper = new TermPaper(formatter)
                {
                    Class = "Design Patterns",
                    Student = "Jose Sanchez",
                    Text = "Blah blah blah...",
                    References = "GOF"
                };
                documents.Add(paper);


                foreach (var doc in documents)
                {
                    sb.Append(doc.Print());
                }

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