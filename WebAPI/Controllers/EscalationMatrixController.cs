using EscalationMatrix.Model;
using WebAPI.IRepositories;
using WebAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EscalationMatrixController : ControllerBase
    {
        public readonly IEscalationMatrixRepository _EscalationMatrixRepository;

        public EscalationMatrixController(IEscalationMatrixRepository EscalationMatrixRepository)
        {
            _EscalationMatrixRepository = EscalationMatrixRepository;
        }

    }
}
