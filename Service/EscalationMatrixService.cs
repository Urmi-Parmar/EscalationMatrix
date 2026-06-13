using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EscalationMatrix.Models;
using EscalationMatrix.Data;
using EscalationMatrix.IService;
using System.Threading.Tasks;

namespace EscalationMatrix.Service
{
	public class EscalationMatrixService : IEscalationMatrixService
    {
        public async Task<List<EMatrixViewModel>> GetData()
        {

        }
    }
}