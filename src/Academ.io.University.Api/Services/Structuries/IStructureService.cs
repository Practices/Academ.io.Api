using System.Collections.Generic;
using Academ.io.Models;

namespace Academ.io.University.Api.Services.Structuries
{
    public interface IStructureService
    {
        IEnumerable<Faculty> GetFaculties();
    }
}