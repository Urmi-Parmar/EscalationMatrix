using EscalationMatrix.Models;
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
        //Task<List<EMatrixViewModel>> GetData1()
        [HttpGet("GetData1")]
        public async Task<IActionResult> GetData1()
        {
            try
            {
                var result = await _EscalationMatrixRepository.GetData1();

                if (result == null || !result.Any())
                {
                    return NotFound("Data not found.");
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.InnerException?.Message ?? ex.Message);
            }
        }
    }
}
