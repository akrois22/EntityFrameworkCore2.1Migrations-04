using Festify.WebRepository.Explore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Festify.Web.Controllers
{
    [Route("conferences")]
    public class ConferenceController : Controller
    {
        private readonly ExploreContext _context;

        public ConferenceController(ExploreContext context)
        {
            _context = context;
        }

        [Route("{identity}")]
        [HttpGet]
        public IActionResult Get(string identity)
        {
            return _context.Conference
                .Where(x => x.Identity == identity)
                .Return(x => (IActionResult)Json(x))
                .OrElse(NotFound);
        }
    }
}