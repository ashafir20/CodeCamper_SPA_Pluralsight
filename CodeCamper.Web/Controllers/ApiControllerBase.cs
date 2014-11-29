using System.Web.Http;
using CodeCamper.Contracts;

namespace CodeCamper.Controllers
{
    public abstract class ApiControllerBase : ApiController
    {
        protected ICodeCamperUow Uow { get; set; }
    }
}