using Microsoft.AspNetCore.Mvc;
using Server___Web_Api.Models;
using Server___Web_Api.BLL;
using Microsoft.AspNetCore.Routing.Matching;
using System.Drawing;

namespace Server___Web_Api.Controllers
{ 
    [Route("api/[controller]")]
    [ApiController]  
    public class CandidatesController : ControllerBase
    {
        private readonly ICandidatesBll _candidates;
        public CandidatesController(ICandidatesBll candidates)
        {
            _candidates = candidates;
        }

        [HttpGet]
        public async Task<List<Candidates>> Get()
        {
            var user = await _candidates.GetCandidateBll();
            return user;

        }
        [HttpGet]
        //public async Task<ActionResult<List<Candidates>>> selectBylanguage(string? name, string? email, string? product)
        //{
        //קוד בערך וגם לא מתחשב בשכבות
        //    var query = _payingContext.Candidates.Where(candidates =>
        //        (name == null) ? (true) : (candidates.FirstName.Contains(name))
        //        && ((email == null) ? : (true) : (candidates.Email.Contain(email))
        //        //&& ((product == null) ? (true) : donor.Include(c => c.
        //)
        //        List<Candidates> candidates = await query.ToListAsync();
        //    return candidates;
        //}
    }
}
