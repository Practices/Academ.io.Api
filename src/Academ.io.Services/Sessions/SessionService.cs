using System;
using System.Collections.Generic;
using System.Linq;
using Academ.io.Api.Models;
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
        private readonly ISessionServiceApi sessionServiceApi;
        private readonly IStudentRepository studentRepository;

        public SessionService(ISessionServiceApi sessionServiceApi, IMarkRepository markRepository, IStudentRepository studentRepository)
        {
            this.sessionServiceApi = sessionServiceApi;
            this.markRepository = markRepository;
            this.studentRepository = studentRepository;

            Mapper.CreateMap<DisciplineModel, Discipline>().ForMember(dest => dest.Mark, opt => opt.Ignore()).ForMember(dest => dest.TestType, opt => opt.Ignore());
        }

        public IEnumerable<Discipline> GetSession(Guid studentId)
        {
            var disciplines = this.sessionServiceApi.GetSessionsByStudent(studentId);

            var result = FillItems(disciplines);

            return result;
        }

        public List<ChartProgressViewModel> GetProgress(int studentId)
        {
            var student = studentRepository.GetStudentsById(studentId);
            if(student == null)
            {
                return null;
            }
            List<Discipline> disciplines = GetSession(student.StudentIdentity).ToList();
            var data = CalcProgress(disciplines);
            return data;
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

        private List<ChartProgressViewModel> CalcProgress(List<Discipline> disciplines)
        {
            var data = new List<ChartProgressViewModel>();

            var checks = new[]
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7
            };
            var testtypes = disciplines.Select(x => x.TestType.TestTypeId);
            var result = testtypes.Intersect(checks);
            foreach(int i in result)
            {
                var possitive = 0;
                var negative = 0;
                var buffer = disciplines.Where(x => x.TestType.TestTypeId == i).ToList();
                foreach(Discipline discipline in buffer)
                {
                    if(discipline.Mark.Grade > 2)
                    {
                        possitive++;
                    }
                    else
                    {
                        negative++;
                    }
                }
                data.Add(new ChartProgressViewModel
                {
                    TestTypeId = i,
                    Name = buffer.First().TestType.Name,
                    Possitive = possitive,
                    Negative = negative
                });
            }

            return data;
        }
    }
}