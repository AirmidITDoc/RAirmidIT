using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
   public interface I_Doctordetils
    {
      public  String Save(DoctorDetailParam DoctorDetailParam);

        bool Update(DoctorDetailParam DoctorDetailParam);
    }
}
