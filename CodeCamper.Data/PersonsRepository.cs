using System.Data.Entity;
using System.Linq;
using CodeCamper.Contracts;
using CodeCamper.Model;

namespace CodeCamper.Data
{
    public class PersonsRepository : EFRepository<Person>, IPersonsRepository
    {
        public PersonsRepository(DbContext dbContext) : base(dbContext) { }

        // <summary>
        /// Get <see cref="Speaker"/>s at sessions.
        /// </summary>
        ///<remarks>
        ///See <see cref="IPersonsRepository.GetSpeakers"/> for details.
        ///</remarks>
        /// 
        public IQueryable<Speaker> GetSpeakers()
        {
            return DbContext
                .Set<Session>()
                .Select(session => session.Speaker)
                .Distinct().Select(s =>
                    new Speaker
                    {
                        Id = s.Id,
                        FirstName = s.FirstName,
                        LastName = s.LastName,
                        ImageSource = s.ImageSource,
                    });

        }
    }
}