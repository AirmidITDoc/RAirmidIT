using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HIMS.Data;
using HIMS.Data.Master;

using HIMS.Model;
using HIMS.Model.Master;

using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HIMS.API.Controllers.Master
{
    [ApiController]
    [Route("api/[controller]")]
    public class MasterController : ControllerBase
    {

       
        public readonly I_MenuMaster _MenuMaster;
        public readonly I_MenuMasterDetails _MenuMasterDetails;
        public readonly I_MenuMasterDetails_Details _MenuMasterDetails_Details;
       

        public MasterController(
            I_MenuMaster menuMaster,
            //I_ProductTypeMasterHome productTypeMaster,
            I_MenuMasterDetails menuMasterDetails,I_MenuMasterDetails_Details menuMasterDetails_Details
            )
        {
          
            this._MenuMaster = menuMaster;
          
           // this._ProductTypeMaster = productTypeMaster;
            this._MenuMasterDetails = menuMasterDetails;
            this._MenuMasterDetails_Details = menuMasterDetails_Details;
            
        }

      
      
      

    }
}
