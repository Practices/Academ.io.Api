using System;
using System.Collections.Generic;
using Academ.io.Models;

namespace Academ.io.Services
{
    public interface ISessionService
    {
        List<Discipline> GetSession(Guid studentId);
    }
}