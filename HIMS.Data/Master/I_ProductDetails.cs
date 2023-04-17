using HIMS.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Master
{
  public  interface I_ProductDetails
    {
        public String Insert(ProductDetailsParam ProductDetailsParam);
        public bool Update(ProductDetailsParam ProductDetailsParam);
    }
}
