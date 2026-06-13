using EscalationMatrix.Models;
using EscalationMatrix.IService;
using Microsoft.AspNetCore.Mvc;
using System.Web.Mvc;

namespace EscalationMatrix.Controllers
{
    public class EMmasterController : Controller
    {
        private readonly IEscalationMatrixService _escalationMatrixService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _configuration;

        public EMmasterController(
            IConfiguration configuration,
            IEscalationMatrixService escalationMatrixService,
            IHttpContextAccessor httpContextAccessor)
        {
            _escalationMatrixService = escalationMatrixService;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
        }

        long userID;
    

        //EMatrixEntities DbContext = new EMatrixEntities();
        // GET: EMmaster
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult EMList()
        {
            var Data = _escalationMatrixService.GetData1();
           

            return View(Data);
        }
        public ActionResult CreateEM()
        {
           // var q1 = DbContext.
            return View();
        }
    }
}