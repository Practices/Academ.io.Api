using System;
using System.Collections.Generic;
using System.Linq;
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
            Mapper.CreateMap<DisciplineModel, Discipline>().ForMember(dest => dest.TestType, opt => opt.Ignore());
            Mapper.AssertConfigurationIsValid();
        }

        public IEnumerable<Discipline> GetSession(Guid studentId)
        {
            var disciplines = this.sessionServiceApi.GetSessionsByStudent(studentId);

            var result = FillItems(disciplines);

            return result;
        }

        private List<Discipline> FillItems(List<DisciplineModel> disciplines)
        {
            return disciplines.Select(MappingItem).ToList();
        }

        private Discipline MappingItem(DisciplineModel disciplineModel)
        {
            var mark = this.markRepository.GetMark(disciplineModel.Mark, disciplineModel.TestType);

            var discipline = Mapper.Map<DisciplineModel, Discipline>(disciplineModel);

            discipline.Mark = mark;
            discipline.TestType = mark.TestType;

            return discipline;
        }
    }
}