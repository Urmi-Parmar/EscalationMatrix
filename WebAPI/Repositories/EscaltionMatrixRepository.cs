using EscaltionMatrix.DBClass;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Repositories
{
    public class EscaltionMatrixRepository
    {
        public async Task<List<EMatrixViewModel>> GetData()
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