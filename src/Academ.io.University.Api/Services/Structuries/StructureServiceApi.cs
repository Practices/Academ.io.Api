using System.Collections.Generic;
using Academ.io.Models;
using Academ.io.University.Api.Models;
using AcademicAnalysis.ElectronicUniversityServices.Models;
using AutoMapper;
using Group = System.Text.RegularExpressions.Group;

namespace Academ.io.University.Api.Services.Structuries
{
    internal class StructureServiceApi: BaseServiceApi, IStructureServiceApi
    {
        private const string StructureUrl = "/service/structure/structure.xml";

        public IEnumerable<Faculty> GetFaculties()
        {
            var request = GetRequest(StructureUrl);
            var response = Client.Execute<StructureModel>(request);

            //Тут надо сворачивать в отдельный класс с помощью автофасом.
            Mapper.CreateMap<GroupModel, Group>();
            Mapper.CreateMap<DepartmentModel, Department>();
            Mapper.CreateMap<FacultyModel, Faculty>();

            IEnumerable<Faculty> faculties = Mapper.Map<IList<FacultyModel>, IList<Faculty>>(response.Data.Facultys);
            return faculties;
        }
    }
}