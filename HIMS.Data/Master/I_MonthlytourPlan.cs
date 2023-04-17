using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
  public  interface I_MonthlytourPlan
    {
        public String Save(MonthlytourPlanParam MonthlytourPlanParam);

        bool Update(MonthlytourPlanParam MonthlytourPlanParam);
    }
}
