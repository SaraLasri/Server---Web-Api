using Server___Web_Api.Models;

namespace Server___Web_Api.BLL
{
    public interface ICandidatesBll
    {
        Task<List<Candidates>> GetCandidateBll();

    }
}
