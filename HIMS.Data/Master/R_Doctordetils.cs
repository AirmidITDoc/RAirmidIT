using HIMS.Common.Utility;
using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Master
{
   public class R_Doctordetils :GenericRepository,I_Doctordetils
    {
        public R_Doctordetils(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public String Save(DoctorDetailParam DoctorDetailParam)
        {
            //throw new NotImplementedException();

            var outputId = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@DoctorID",
                Value = 0,
                Direction = ParameterDirection.Output
            };
            var disc = DoctorDetailParam.DoctordetailInsert.ToDictionary();
            disc.Remove("DoctorID");
            var Id=ExecNonQueryProcWithOutSaveChanges("Insert_DoctorDetails", disc,outputId);

            //commit transaction
            _unitofWork.SaveChanges();
            return Id;
        }

        public bool Update(DoctorDetailParam DoctorDetailParam)
        {
            //throw new NotImplementedException();
            var disc = DoctorDetailParam.DoctordetailUpdate.ToDictionary();
            ExecNonQueryProcWithOutSaveChanges("UpdDel_DoctorDetails", disc);

            //commit transaction
            _unitofWork.SaveChanges();
            return true;
        }
    }
}
