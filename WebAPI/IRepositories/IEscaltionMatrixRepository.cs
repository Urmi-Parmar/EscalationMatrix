using EscalationMatrix.Models;

namespace ePortalWebAPI.IRepositories
{
    public interface IEscalationMatrixRepository
    {
        public async Task<List<EMatrixViewModel>> GetData1()
        {
            List<EMatrixViewModel> obj = new List<EMatrixViewModel>();

            return obj;
            //using (var dbContext = new EMatrixEntities())
            //{
            //    var data = await dbContext.EM_Header
            //        .Select(x => new EMatrixViewModel
            //        {
            //            HeaderID = x.EMHeader,
            //            ComplaintType = x.ComplaintType,
            //            ScopeofWork = x.ScopeofWork,
            //            Addedby = x.Addedby,
            //            AddedOn = x.AddedOn,
            //            Updateby = x.Updateby,
            //            UpdateOn = x.UpdateOn
            //        })
            //        .ToListAsync();

            //    return data;
            //}
        }
    }
}