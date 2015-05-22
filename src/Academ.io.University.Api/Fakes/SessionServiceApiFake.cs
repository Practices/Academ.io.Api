using System;
using System.Collections.Generic;
using Academ.io.University.Api.Models;
using Academ.io.University.Api.Services.Sessions;

namespace Academ.io.University.Api.Fakes
{
    public class SessionServiceApiFake: ISessionServiceApi
    {
        private List<DisciplineModel> session = GenerateData.GetDisciplines();

        public List<DisciplineModel> GetSessionsByStudent(string id)
        {
            return this.session;
        }

        public List<DisciplineModel> GetSessionsByStudent(Guid id)
        {
            return this.session;
        }
    }
}