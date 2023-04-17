using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Master
{
   public class MonthlytourPlanParam
    {
        public TourDetailInsert TourDetailInsert { get; set; }
        public TourDetailUpdate TourDetailUpdate { get; set; }
    }

    public class TourDetailInsert
    {
      
        public int TourPlanId { get; set; }
        public int MRId { get; set; }
        public int PlanYear { get; set; }
        public string PlanMonth { get; set; }
        public DateTime PlanDate { get; set; }
        public String WorkingWith { get; set; }
        public String Activity { get; set; }
     
        public String CreatedBy { get; set; }
        public String UpdatedBy { get; set; }
    }

    public class TourDetailUpdate
    {
        public String Operation { get; set; }
        public int TourPlanId { get; set; }
        public int MRId { get; set; }
        public int PlanYear { get; set; }
        public string PlanMonth { get; set; }
        public DateTime PlanDate { get; set; }
        public String WorkingWith { get; set; }
        public String Activity { get; set; }

        public String UpdatedBy { get; set; }
    }
}
