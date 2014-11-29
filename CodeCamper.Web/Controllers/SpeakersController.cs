using System.Collections.Generic;
using System.Linq;
using CodeCamper.Contracts; 
using CodeCamper.Model;

namespace CodeCamper.Controllers
{
    public class SpeakersController : ApiControllerBase
    {
        public SpeakersController(ICodeCamperUow uow)
        {
            Uow = uow;
        }

        // GET api/speakers
        public IEnumerable<Speaker> Get()
        {
            return Uow.Persons.GetSpeakers().OrderBy(s => s.FirstName);
        }
    }
}
