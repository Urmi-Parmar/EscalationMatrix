using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EscalationMatrix.Models
{
	public class EMatrixViewModel
	{
		public int HeaderID { get; set; }
		public string ComplaintType { get; set; }
		public string ScopeofWork { get; set; }
		public int? Addedby { get; set;}
		public DateTime? AddedOn { get; set; }
		public int? Updateby { get; set; }
		public DateTime? UpdateOn { get; set; }
    }
    public class EMatrixHistoryViewModel
    {
        public int HeaderID { get; set; }
        public int HID { get; set; }
        public string Window { get; set; }
        public string NameOfAssociate { get; set; }
        public string ContactDetails { get; set; }        
        public int? Addedby { get; set; }
        public DateTime AddedOn { get; set; }
        public int? Updateby { get; set; }
        public DateTime UpdateOn { get; set; }
    }
    public class DepartmentMaster
    {
        public int Id { get; set; }
        public int? DId { get; set; }
        public string Department { get; set; }
    }
}