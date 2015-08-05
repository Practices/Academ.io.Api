using System.Collections.Generic;
using System.Linq;
using Academ.io.Data.Repositories;
using Academ.io.Models;
using Academ.io.University.Api.Models;
using Academ.io.University.Api.Services.Sessions;
using AutoMapper;

namespace Academ.io.Services.Sessions
{
    public class SessionService: ISessionService
    {
        private readonly IMarkRepository markRepository;
        private readonly ISessionRepository sessionRepository;
        private readonly ISessionServiceApi sessionServiceApi;
        private readonly IStudentRepository studentRepository;

        public SessionService(ISessionServiceApi sessionServiceApi,
                              IMarkRepository markRepository,
                              IStudentRepository studentRepository,
                              ISessionRepository sessionRepository)
        {
            this.sessionServiceApi = sessionServiceApi;
            this.markRepository = markRepository;
            this.studentRepository = studentRepository;
            this.sessionRepository = sessionRepository;
        }

        public IEnumerable<Discipline> GetSession(int studentId)
        {
            var student = studentRepository.GetStudentsById(studentId);

            if(student == null)
            {
                return null;
            }

            var disciplines = this.sessionServiceApi.GetSessionsByStudent(student.StudentIdentity);

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