using Newtonsoft.Json;
using Server___Web_Api.DAL;
using Server___Web_Api.Models;

namespace Server___Web_Api.BLL
{
    public class CandidatesBll : ICandidatesBll
    {
        private readonly ICandidatesDal _candidate;
        public CandidatesBll(ICandidatesDal candidate)
        {
            _candidate = candidate;
        }
        public async Task<List<Candidates>> GetCandidateBll()
        {
            string response = await _candidate.GetCandidateDal();
            List<Candidates> users = JsonConvert.DeserializeObject<List<Candidates>>(response);
            return users;
        }
    }
}
