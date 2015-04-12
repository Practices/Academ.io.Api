using System.Collections.Generic;
using Academ.io.Models;

namespace Academ.io.Data.Repositories
{
    public interface IMarkRepository
    {
        List<Mark> GetMarks();
        List<TestType> GetTestTypes();
        Mark GetMark(int mark, int type);
    }
}