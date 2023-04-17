using HIMS.Common.Utility;
using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Master
{
   public class R_MonthlytourPlan :GenericRepository,I_MonthlytourPlan
    {
        public R_MonthlytourPlan(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public string Save(MonthlytourPlanParam MonthlytourPlanParam)
        {
            // throw new NotImplementedException();

            var outputId = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@TourPlanId",
                Value = 0,
                Direction = ParameterDirection.Output
            };
            var disc = MonthlytourPlanParam.TourDetailInsert.ToDictionary();
            disc.Remove("TourPlanId");
            var Id = ExecNonQueryProcWithOutSaveChanges("Insert_MonthlyTourPlan", disc, outputId);

            //commit transaction
            _unitofWork.SaveChanges();
            return Id;
        }

        public bool Update(MonthlytourPlanParam MonthlytourPlanParam)
        {
            //throw new NotImplementedException();

            var disc = MonthlytourPlanParam.TourDetailUpdate.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("Insert_CityDetails", disc);

            //commit transaction
            _unitofWork.SaveChanges();
            return true;
        }
    }
}
