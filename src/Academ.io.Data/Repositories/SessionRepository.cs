using System;
using System.Data.Entity.Migrations;
using System.Linq;
using Academ.io.Data.Contexts;
using Academ.io.Models;

namespace Academ.io.Data.Repositories
{
    public class SessionRepository: ISessionRepository
    {
        private AcademContext context;

        public SessionRepository(AcademContext context)
        {
            this.context = context;
        }

        public Session GetLastSession()
        {
            return context.Sessions.Last();
        }

        public SessionPoint GetSessionPoint(Student student, Session session)
        {
            return context.SessionPoints.Where(x => x.Student == student).SingleOrDefault(x => x.Session == session);
        }

        public void UpdateSessionPoint(SessionPoint sessionPoint)
        {
            context.SessionPoints.AddOrUpdate(sessionPoint);
            context.SaveChanges();
        }

        public void AddSessionPoint(SessionPoint sessionPoint)
        {
            context.SessionPoints.Add(sessionPoint);
            context.SaveChanges();
        }

        public SessionPoint GetLastChangePointDate(Student student, DateTime lastPassDate)
        {
            var date = lastPassDate;

            var session = context.Sessions.Last();

            if(session.OpenDate < lastPassDate)
            {
                var point = context.SessionPoints.Where(x => x.Student == student).SingleOrDefault(x=>x.Session == session);

                if(point == null)
                {
                    return new SessionPoint()
                    {
                        Student = student,
                        Session = session
                    };
                }

                if(point.LastPassDate != lastPassDate)
                {
                    return point;
                }
            }
            
            return null;
        }
    }
}