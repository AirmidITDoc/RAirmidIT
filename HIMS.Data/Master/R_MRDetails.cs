using HIMS.Common.Utility;
using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Master
{
  public  class R_MRDetails:GenericRepository,I_MRDetails
    {
        public R_MRDetails(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public string Insert(MRDetailsparam MRDetailsparam)
        {
            // throw new NotImplementedException();

            var outputId = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@MrId",
                Value = 0,
                Direction = ParameterDirection.Output
            };

            var disc = MRDetailsparam.MEInsert.ToDictionary();
            disc.Remove("MrId");
            var Id = ExecNonQueryProcWithOutSaveChanges("Insert_MRDetails", disc,outputId);

            //commit transaction
            _unitofWork.SaveChanges();
            return Id;
        }

        public bool Update(MRDetailsparam MRDetailsparam)
        {
            //throw new NotImplementedException();
            var disc = MRDetailsparam.MRUpdate.ToDictionary();
            var Id = ExecNonQueryProcWithOutSaveChanges("UpdDel_MRDetails", disc);

            //commit transaction
            _unitofWork.SaveChanges();
            return true;
        }
    }
}
