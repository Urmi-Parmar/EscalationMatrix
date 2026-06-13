using EscalationMatrix.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace EscalationMatrix.IService
{
	public class IEscalationMatrixService
	{
		Task<List<EMatrixViewModel>> GetData();

    }
}