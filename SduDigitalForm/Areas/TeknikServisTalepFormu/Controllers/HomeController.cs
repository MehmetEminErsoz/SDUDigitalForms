using Microsoft.AspNetCore.Mvc;
using SduDigitalForm.Areas.TeknikServisTalepFormu.Models;
using SduDigitalForm.Business.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SduDigitalForm.Areas.TeknikServisTalepFormu.Controllers
{
    [Area("TeknikServisTalepFormu")]
    [Route("TeknikServisTalepFormu/Home")]
    public class HomeController : Controller
    {

        public List<OrnekModel> OrnekList;
        public List<TypeDeviceDto> TypeDeviceList;
        public List<OrganizationUnitDto> OrgUnitList;
        public List<TypeIssueDto> TypeIssueList;


        [HttpGet]
        public IActionResult Index()
        {
            List<TypeDeviceDto> list = dbContext.Tbl_TypeDevices.Select(x => new TypeDeviceDto()
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
            
            return View(list);
        }

        [HttpPost]
        public IActionResult Index(TeknikServisTalepFormuViewModel model)
        {
            
            return View();
        }



    }
}
