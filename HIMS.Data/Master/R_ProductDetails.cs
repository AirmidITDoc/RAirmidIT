using HIMS.Common.Utility;
using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace HIMS.Data.Master
{
    public class R_ProductDetails :GenericRepository,I_ProductDetails
    {
        public R_ProductDetails(IUnitofWork unitofWork) : base(unitofWork)
        {
            //transaction and connection is open when you inject unitofwork
        }

        public string Insert(ProductDetailsParam ProductDetailsParam)
        {
            // throw new NotImplementedException();

            var outputId = new SqlParameter
            {
                SqlDbType = SqlDbType.BigInt,
                ParameterName = "@ProductID",
                Value = 0,
                Direction = ParameterDirection.Output
            };
            var disc = ProductDetailsParam.ProductInsert.ToDictionary();
            disc.Remove("ProductID");
            var Id = ExecNonQueryProcWithOutSaveChanges("Insert_ProductDetails", disc,outputId);

            //commit transaction
            _unitofWork.SaveChanges();
            return Id;
        }

        public bool Update(ProductDetailsParam ProductDetailsParam)
        {
            // throw new NotImplementedException();
            var disc = ProductDetailsParam.ProductUpdate.ToDictionary();
            var Id = ExecNonQueryProcWithOutSaveChanges("UpdDel_ProductDetails", disc);

            //commit transaction
            _unitofWork.SaveChanges();
            return true;
        }
    }
}
