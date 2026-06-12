using EscalationMatrix.DBClass;
using EscalationMatrix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EscalationMatrix.Controllers
{
    public class EMmasterController : Controller
    {
        EMatrixEntities DbContext = new EMatrixEntities();
        // GET: EMmaster
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult EMList()
        {
            var q1 = DbContext.EM_Header
                     .Select(x => new EMatrixViewModel
                     {
                         HeaderID = x.EMHeader,
                         ComplaintType = x.ComplaintType,
                         ScopeofWork = x.ScopeofWork,
                         Addedby = x.Addedby,
                         AddedOn = x.AddedOn,
                         Updateby = x.Updateby,
                         UpdateOn = x.UpdateOn
                     })
                     .ToList();

            return View(q1);
        }
        public ActionResult CreateEM()
        {
            var q1 = DbContext.
            return View();
        }
    }
}