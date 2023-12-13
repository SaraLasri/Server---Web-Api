using Microsoft.AspNetCore.Mvc;
using Server___Web_Api.Models;
using System.Drawing;

namespace Server___Web_Api.DAL
{
    public class CandidatesDal : ICandidatesDal
    {
        private readonly HttpClient httpClient;
        public CandidatesDal(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async  Task<string> GetCandidateDal()
        {
            string url = "https://raw.githubusercontent.com/ozsoftware/canidates/main/db.json";
            try
            {
                var client = new HttpClient();
                var response = await client.GetAsync(url);
                var conect = await response.Content.ReadAsStringAsync();
                return conect;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception"+exception);
                return null;
            }
        }
    }
}
