using System;
using System.Collections.Generic;
using Academ.io.Models;
using Academ.io.University.Api.Models;
using AutoMapper;

namespace Academ.io.University.Api.Services.Contingents
{
    public interface IStudentServiceApi
    {
        IEnumerable<StudentModel> GetStudentsByContainer(string value);
        IEnumerable<StudentModel> GetStudentById(string value);
        IEnumerable<StudentModel> GetStudentByFamily(string value);
        IEnumerable<StudentModel> GetStudentByCardnumber(string value);
        IEnumerable<GroupModel> GetGroupsByName(string value);
    }
}