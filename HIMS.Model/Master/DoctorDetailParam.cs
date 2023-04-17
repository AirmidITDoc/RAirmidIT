using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Master
{
  public  class DoctorDetailParam
    {
        public DoctordetailInsert DoctordetailInsert { get; set; }
        public DoctordetailUpdate DoctordetailUpdate { get; set; }
    }

    public class DoctordetailInsert
    {
        
        public int DoctorID { get; set; }
        public string DoctorName { get; set; }
        public string Qualification { get; set; }
        public string Specialization { get; set; }
        public string Frequency { get; set; }
        public int CityId { get; set; }
        public String Address { get; set; }
        public int MobileNo { get; set; }
        public DateTime DOB { get; set; }
             
        public String CreatedBy { get; set; }
        public String UpdatedBy { get; set; }
    }

    public class DoctordetailUpdate
    {
        public String Operation { get; set; }
        public int DoctorID { get; set; }
        public string DoctorName { get; set; }
        public string Qualification { get; set; }
        public string Specialization { get; set; }
        public string Frequency { get; set; }
        public int CityId { get; set; }
        public String Address { get; set; }
        public int MobileNo { get; set; }
        public DateTime DOB { get; set; }

        public String UpdatedBy { get; set; }
    }
}

