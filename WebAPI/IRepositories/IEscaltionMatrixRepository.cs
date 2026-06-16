using EscalationMatrix.Models;

namespace WebAPI.IRepositories
{
    public interface IEscalationMatrixRepository
    {
        Task<List<EMatrixViewModel>> GetData1();
    }
}