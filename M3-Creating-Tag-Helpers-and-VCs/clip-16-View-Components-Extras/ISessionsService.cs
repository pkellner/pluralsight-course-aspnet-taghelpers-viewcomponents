using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAppTagHelper
{
    public interface ISessionsService
    {
        Task<List<Session>> GetSessions(int speakerId,string baseUrl);
    }
}

