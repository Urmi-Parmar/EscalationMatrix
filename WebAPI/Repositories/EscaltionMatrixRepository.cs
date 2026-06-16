using EscalationMatrix.DBClass;
//using Microsoft.EntityFrameworkCore;
using WebAPI.IRepositories;
using EscalationMatrix.Models;

namespace WebAPI.Repositories
{
    public class EscalationMatrixRepository : IEscalationMatrixRepository
    {
        public async Task<List<EMatrixViewModel>> GetData1()
        {
            using (var dbContext = new EMatrixEntities())
            {
                var data = await dbContext.EM_Header
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
                    .ToListAsync();

                return data;
            }
        }
    }
}