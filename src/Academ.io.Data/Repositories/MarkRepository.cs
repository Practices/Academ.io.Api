using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Academ.io.Data.Contexts;
using Academ.io.Models;

namespace Academ.io.Data.Repositories
{
    public class MarkRepository: IMarkRepository
    {
        private readonly SessionContext sessionContext;

        public MarkRepository(SessionContext sessionContext)
        {
            this.sessionContext = sessionContext;
        }

        public Mark GetMark(int mark, int type)
        {
            return this.sessionContext.Marks.Include(x => x.TestType).Where(x => x.Grade == mark).FirstOrDefault(x => x.TestType.TestTypeId == type);
        }

        public List<Mark> GetMarks()
        {
            return this.sessionContext.Marks.Include(x => x.TestType).ToList();
        }

        public List<TestType> GetTestTypes()
        {
            return this.sessionContext.TestTypes.ToList();
        }
    }
}