using System;
using System.Collections.Generic;
using Academ.io.Models;

namespace Academ.io.Services
{
    public interface ISessionService
    {
        IEnumerable<Discipline> GetSession(Guid studentId);
    }
}