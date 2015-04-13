using System;
using System.Collections.Generic;
using Academ.io.Models;
using Academ.io.University.Api.Models;

namespace Academ.io.University.Api.Services.Sessions
{
    public interface ISessionServiceApi
    {
        List<DisciplineModel> GetSessionsByStudent(string id);
        List<DisciplineModel> GetSessionsByStudent(Guid id);
    }
}