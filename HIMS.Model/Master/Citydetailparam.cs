using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Master
{
   public class Citydetailparam
    {
        public CityInsert CityInsert { get; set; }
        public CityUpdate CityUpdate { get; set; }

    }

    public class CityInsert
    {
       

        public int CityID { get; set; }

        public String CityName { get; set; }

        public int HeadQuarterId { get; set; }
        public float KiloMeter { get; set; }
        public float DailyAllowance { get; set; }
        public String CreatedBy { get; set; }

        public String UpdatedBy { get; set; }

    }

    public class CityUpdate
    {

        public String Operation { get; set; }
        public int CityID { get; set; }

        public String CityName { get; set; }

        public int HeadQuarterId { get; set; }
        public float KiloMeter { get; set; }
        public float DailyAllowance { get; set; }
        

        public String UpdatedBy { get; set; }
    }

}
