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
        public readonly I_Doctordetils _Doctordetils;
        public readonly I_Citydetail _Citydetail;
        public readonly I_MRDetails _MRDetails;
        public readonly I_MonthlytourPlan _MonthlytourPlan;
        public readonly I_ProductDetails _ProductDetails;

        public MasterController(
            I_MenuMaster menuMaster,
            //I_ProductTypeMasterHome productTypeMaster,
            I_MenuMasterDetails menuMasterDetails,I_MenuMasterDetails_Details menuMasterDetails_Details
            , I_Doctordetils doctordetils, I_Citydetail citydetail, I_MRDetails mRDetails, I_ProductDetails productDetails, I_MonthlytourPlan monthlytourPlan
            )
        {
          
            this._MenuMaster = menuMaster;
          
           // this._ProductTypeMaster = productTypeMaster;
            this._MenuMasterDetails = menuMasterDetails;
            this._MenuMasterDetails_Details = menuMasterDetails_Details;
            this._Doctordetils = doctordetils;
            this._Citydetail = citydetail;
            this._MRDetails = mRDetails;
            this._ProductDetails = productDetails;
            this._MonthlytourPlan = monthlytourPlan;

        }



        // DoctordetailInsert Save /update
        [HttpPost("DoctorInsert")]
        public IActionResult DoctorInsert(DoctorDetailParam DoctorDetailParam)
        {
            var ServiceSave = _Doctordetils.Save(DoctorDetailParam);
            return Ok(ServiceSave);
        }

        [HttpPost("DoctorUpdate")]
        public IActionResult DoctorUpdate(DoctorDetailParam DoctorDetailParam)
        {
            var ServiceSave = _Doctordetils.Update(DoctorDetailParam);
            return Ok(ServiceSave);
        }

        // CitydetailInsert Save /update
        [HttpPost("CityInsert")]
        public IActionResult CityInsert(Citydetailparam Citydetailparam)
        {
            var ServiceSave = _Citydetail.Insert(Citydetailparam);
            return Ok(ServiceSave);
        }

        [HttpPost("CityUpdate")]
        public IActionResult CityUpdate(Citydetailparam Citydetailparam)
        {
            var ServiceSave = _Citydetail.Update(Citydetailparam);
            return Ok(ServiceSave);
        }


        // MrdetailInsert Save /update
        [HttpPost("MRInsert")]
        public IActionResult MRInsert(MRDetailsparam MRDetailsparam)
        {
            var ServiceSave = _MRDetails.Insert(MRDetailsparam);
            return Ok(ServiceSave);
        }

        [HttpPost("MRUpdate")]
        public IActionResult MRUpdate(MRDetailsparam MRDetailsparam)
        {
            var ServiceSave = _MRDetails.Update(MRDetailsparam);
            return Ok(ServiceSave);
        }

        // ProductdetailInsert Save /update
        [HttpPost("ProductInsert")]
        public IActionResult ProductInsert(ProductDetailsParam ProductDetailsParam)
        {
            var ServiceSave = _ProductDetails.Insert(ProductDetailsParam);
            return Ok(ServiceSave);
        }

        [HttpPost("ProductUpdate")]
        public IActionResult ProductUpdate(ProductDetailsParam ProductDetailsParam)
        {
            var ServiceSave = _ProductDetails.Update(ProductDetailsParam);
            return Ok(ServiceSave);
        }

        // Monthly TourPlan Save /update
        [HttpPost("MonthlyTourInsert")]
        public IActionResult MonthlyTourInsert(MonthlytourPlanParam MonthlytourPlanParam)
        {
            var ServiceSave = _MonthlytourPlan.Save(MonthlytourPlanParam);
            return Ok(ServiceSave);
        }

      /*  [HttpPost("MonthlyTourUpdate")]
        public IActionResult MonthlyTourUpdate(MonthlytourPlanParam MonthlytourPlanParam)
        {
            var ServiceSave = _MonthlytourPlan.Update(MonthlytourPlanParam);
            return Ok(ServiceSave);
        }
      */

    }
}
