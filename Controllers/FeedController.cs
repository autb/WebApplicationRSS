using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationRSS.Providers.Abstractions;

namespace WebApplicationRSS
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedController : ControllerBase
    {
        private readonly IFeedService _feed;

        public FeedController(IFeedService feed)
        {
            _feed = feed;
        }

        [HttpGet, Route("rss")]
        public async Task<IActionResult> Rss()
        {
            string host = Request.Scheme + "://" + Request.Host;
            string contentType = "application/xml";

            var content = await _feed.GetFeedDocument(host);
            return Content(content, contentType);
        }
    }
}
