using Microsoft.AspNetCore.Mvc;
using SduDigitalForm.Areas.TeknikServisTalepFormu.Models;
using SduDigitalForm.Business;
using SduDigitalForm.Business.Dto;
using SduDigitalForm.Data;
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
        public List<UsersDto> UserList;
        public string Sayinkisi;


        //Dbcontext ten türetmek yerine doğru olanı Servisi türetmek servisteki veri çekme metodlarını kullanmak
        public OrnekServis ServiceMVC;
        public HomeController()
        {
            ServiceMVC = new OrnekServis();
        }
        private TeknikServisTalepFormuViewModel GetDefaultModel()
        {
            
            var model = new TeknikServisTalepFormuViewModel()
            {
                TypeDeviceList = ServiceMVC.GetTypeDeviceDto(),
                TypeIssueList = ServiceMVC.GetTypeIssueDto(),
                //userList = ServiceMVC.GetUsersDto(),
                
            };
            model.sayinkisi = Sayinkisi;
            return model;
        }

        [HttpGet]
        public IActionResult Index()
        {
           
            var model = GetDefaultModel();
          
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(TeknikServisTalepFormuViewModel model)
        {
            var dtoModel = new IssueDto() { 
                Phone=model.Phone,
                Address=model.Address,
                Delivered=model.Delivered,
                DeliveryDate=model.DeliveryDate,
                Giver=model.Giver,
                Mail=model.Mail,
                Note=model.Note,
                RepairCustomer=model.RepairCustomer,
                RepairDate=model.RepairDate,
                TypeDeviceId=model.TypeDeviceId,
                TypeIssueId=model.TypeIssueId,
                UserId=model.UserId
            };
            ServiceMVC.PostIssue(dtoModel);


            Sayinkisi = ServiceMVC.UserCall(model.Mail);
           
            
            //ViewData["islemSonuc"] = "Başarılı";
            var defaultModel = GetDefaultModel();
            
            
            return View(defaultModel);
        }

        public IActionResult cihazcek()
        {
           var list= ServiceMVC.GetTypeDeviceDto();

            return View(list);
        }

      

        public IActionResult arizacek()
        {
            var listAriza = ServiceMVC.GetTypeIssueDto();

            return View(listAriza);
        }


    }
}
