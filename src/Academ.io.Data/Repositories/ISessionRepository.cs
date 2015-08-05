using System;
using Academ.io.Models;

namespace Academ.io.Data.Repositories
{
    public interface ISessionRepository
    {
        SessionPoint GetLastChangePointDate(Student student, DateTime lastPassDate);
        Session GetLastSession();
        SessionPoint GetSessionPoint(Student student, Session session);
        void UpdateSessionPoint(SessionPoint sessionPoint);
        void AddSessionPoint(SessionPoint sessionPoint);
    }
}