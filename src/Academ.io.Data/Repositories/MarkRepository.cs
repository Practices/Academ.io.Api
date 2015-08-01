using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Academ.io.Data.Contexts;
using Academ.io.Models;

namespace Academ.io.Data.Repositories
{
    public class MarkRepository: IMarkRepository
    {
        public List<Mark> Marks { get; private set; }
        public List<TestType> TestTypes { get; private set; }

        public MarkRepository(AcademContext sessionContext)
        {
            Marks = sessionContext.Marks.Include(x => x.TestType).ToList();
            TestTypes = sessionContext.TestTypes.ToList();
        }

        public Mark GetMark(int mark, int type)
        {
            return this.Marks.Where(x => x.Grade == mark).FirstOrDefault(x => x.TestType.TestTypeId == type);
        }

        public List<Mark> GetMarks()
        {
            return Marks;
        }

        public List<TestType> GetTestTypes()
        {
            return this.TestTypes;
        }
    }
}