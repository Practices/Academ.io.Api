using System;
using System.Collections.Generic;
using Academ.io.Models;

namespace Academ.io.Services.Sessions
{
    public interface ISessionService
    {
        IEnumerable<Discipline> GetSession(int studentId);
    }
}