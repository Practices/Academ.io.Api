using System;
using System.Collections.Generic;
using Academ.io.Models;

namespace Academ.io.Services
{
    public interface ISessionService
    {
        IEnumerable<Session> GetSessions(Guid studentId);
    }
}