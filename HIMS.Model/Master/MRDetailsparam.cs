using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Master
{
   public class MRDetailsparam
    {
        public MEInsert MEInsert { get; set; }
        public MRUpdate MRUpdate { get; set; }

    }

    public class MEInsert
    {

      
        public int MrId { get; set; }

        public String MrName { get; set; }

        public String Address { get; set; }
        public int MobileNo { get; set; }
        public String EmailId { get; set; }

        public int HqId { get; set; }

        public String UserName { get; set; }
        public String Password { get; set; }
        public String IdentityNo { get; set; }

        public float DailyAllowance { get; set; }

        public float FuelRate { get; set; }
      
        public String CreatedBy { get; set; }

        public String UpdatedBy { get; set; }

    }

    public class MRUpdate
    {

        public String Operation { get; set; }
        public int MrId { get; set; }

        public String MrName { get; set; }

        public String Address { get; set; }
        public int MobileNo { get; set; }
        public String EmailId { get; set; }

        public int HqId { get; set; }

        public String UserName { get; set; }
        public String Password { get; set; }
        public String IdentityNo { get; set; }

        public float DailyAllowance { get; set; }

        public float FuelRate { get; set; }

        
        public String UpdatedBy { get; set; }
    }

}
