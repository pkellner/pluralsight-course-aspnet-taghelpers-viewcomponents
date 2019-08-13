using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAppTagHelper.Models;

namespace WebAppTagHelper
{
    public interface ISessionsService
    {
        Task<List<Session>> GetSessions(int speakerId,string baseUrl);
    }
}

