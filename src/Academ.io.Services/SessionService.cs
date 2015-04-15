using System;
using System.Collections.Generic;
using Academ.io.Data.Repositories;
using Academ.io.Models;
using Academ.io.University.Api.Models;
using Academ.io.University.Api.Services.Sessions;
using AutoMapper;

namespace Academ.io.Services
{
    public class SessionService: ISessionService
    {
        private readonly IMarkRepository markRepository;
        private readonly ISessionServiceApi sessionServiceApi;

        public SessionService(ISessionServiceApi sessionServiceApi, IMarkRepository markRepository)
        {
            this.sessionServiceApi = sessionServiceApi;
            this.markRepository = markRepository;

            Mapper.CreateMap<DisciplineModel, Discipline>().ForMember(dest => dest.Mark, opt => opt.Ignore());
            Mapper.AssertConfigurationIsValid();
        }

        public List<Discipline> GetSession(Guid studentId)
        {
            var disciplines = this.sessionServiceApi.GetSessionsByStudent(studentId);

            var result = FillDisciplines(disciplines);

            return result;
        }

        private List<Discipline> FillDisciplines(List<DisciplineModel> disciplines)
        {
            var result = new List<Discipline>();

            foreach(var item in disciplines)
            {
                result.Add(ConvertDiscipline(item));
            }
            return result;
        }

        private Discipline ConvertDiscipline(DisciplineModel disciplineModel)
        {
            var mark = this.markRepository.GetMark(disciplineModel.Mark, disciplineModel.TestType);

            var discipline = Mapper.Map<DisciplineModel, Discipline>(disciplineModel);

            discipline.Mark = mark;

            return discipline;
        }
    }
}