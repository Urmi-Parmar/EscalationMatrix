using EscalationMatrix.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace EscalationMatrix.IService
{
	public interface IEscalationMatrixService
	{
		Task<List<EMatrixViewModel>> GetData1();

    }
}