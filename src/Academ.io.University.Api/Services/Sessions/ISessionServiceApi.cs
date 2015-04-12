using System;
using System.Collections.Generic;
using Academ.io.Models;

namespace Academ.io.University.Api.Services.Sessions
{
    public interface ISessionServiceApi
    {
        IEnumerable<Session> GetSessionsByStudent(string id);
        IEnumerable<Session> GetSessionsByStudent(Guid id);
    }
}