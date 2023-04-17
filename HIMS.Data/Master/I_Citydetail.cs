using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
   public interface I_Citydetail
    {
        public String Insert(Citydetailparam Citydetailparam);
        public bool Update(Citydetailparam Citydetailparam);
    }
}
