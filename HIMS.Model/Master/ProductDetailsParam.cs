using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Model.Master
{
   public class ProductDetailsParam
    {
        public ProductInsert ProductInsert { get; set; }
        public ProductUpdate ProductUpdate { get; set; }

    }

    public class ProductInsert
    {

        
        public int ProductID { get; set; }

        public String ProductName { get; set; }

        public String ProductManufacturer { get; set; }
       
        public String CreatedBy { get; set; }

        public String UpdatedBy { get; set; }

    }

    public class ProductUpdate
    {

        public String Operation { get; set; }
        public int ProductID { get; set; }

        public String ProductName { get; set; }

        public String ProductManufacturer { get; set; }


        public String UpdatedBy { get; set; }
    }

}