using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebAppTagHelper.Models;

namespace WebAppTagHelper
{

  
    public class SessionsService : ISessionsService
    {
        public async Task<List<Session>> GetSessions(int speakerId,string baseUrl)
        {
            var uri = new Uri(Path.Join(baseUrl, "/api/sessions"));
            var httpClient = new HttpClient();
            var result = await httpClient.GetStringAsync(uri);
            var sessions = JsonConvert.DeserializeObject<List<Session>>(result);
            return sessions.Where(a => a.SpeakerId == speakerId).ToList();
        }

    }

}
