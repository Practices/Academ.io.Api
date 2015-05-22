using System;
using System.Collections.Generic;
using Academ.io.Api.Models;
using Academ.io.Models;

namespace Academ.io.Services.Sessions
{
    public interface ISessionService
    {
        IEnumerable<Discipline> GetSession(Guid studentId);
        List<ChartProgressViewModel> GetProgress(int studentId);
    }
}