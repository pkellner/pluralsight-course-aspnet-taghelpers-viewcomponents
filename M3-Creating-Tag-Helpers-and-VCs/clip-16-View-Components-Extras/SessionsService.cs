using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebAppTagHelper
{

    public class Session
    {
        public int SpeakerId { get; set; }
        public string Title { get; set; }
    }

    public class SessionsService : ISessionsService
    {
        public async Task<List<Session>> GetSessions(int speakerId,string baseUrl)
        {
            
            var uri = new Uri($"{baseUrl}api/sessions");
            var httpClient = new HttpClient();
            var result = await httpClient.GetStringAsync(uri);
            var sessions = JsonConvert.DeserializeObject<List<Session>>(result);
            return sessions.Where(a => a.SpeakerId == speakerId).ToList();
        }

    }

}
