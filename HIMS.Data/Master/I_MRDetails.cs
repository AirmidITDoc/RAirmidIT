using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
   public interface I_MRDetails
    {
        public String Insert(MRDetailsparam MRDetailsparam);
        public bool Update(MRDetailsparam MRDetailsparam);
    }
}
