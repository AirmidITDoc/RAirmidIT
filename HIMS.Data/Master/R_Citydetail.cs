using HIMS.Common.Utility;
using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Master
{
  public  class R_Citydetail:GenericRepository,I_Citydetail
    {
        public R_Citydetail(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public string Insert(Citydetailparam Citydetailparam)
        {
            //throw new NotImplementedException();

            var outputId = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@CityID",
                Value = 0,
                Direction = ParameterDirection.Output
            };
            var disc = Citydetailparam.CityInsert.ToDictionary();
            disc.Remove("CityID");
            var Id = ExecNonQueryProcWithOutSaveChanges("Insert_CityDetails", disc,outputId);

            //commit transaction
            _unitofWork.SaveChanges();
            return Id;
        }

        public bool Update(Citydetailparam Citydetailparam)
        {
            // throw new NotImplementedException();

            var disc = Citydetailparam.CityUpdate.ToDictionary();
            var Id = ExecNonQueryProcWithOutSaveChanges("UpdDel_CityDetails", disc);

            //commit transaction
            _unitofWork.SaveChanges();
            return true;
        }
    }
}
