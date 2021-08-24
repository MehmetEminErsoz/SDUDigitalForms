using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SduDigitalForm.Business;
using SduDigitalForm.Business.Dto;
using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SduDigitalForm.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<OrnekModel> OrnekList;
        public List<TypeDeviceDto> TypeDeviceList;
        public List<OrganizationUnitDto> OrgUnitList;
        public List<TypeIssueDto> TypeIssueList;
        private readonly OrnekServis servis;
        [BindProperty]
        public int Id { get; set; }
        [BindProperty]
        public int UserId { get; set; }
        [BindProperty]
        public int TypeIssueId { get; set; }
        [BindProperty]
        public int RepairCustomer { get; set; }
        [BindProperty]
        public int Delivered { get; set; }
        [BindProperty]
        public int Giver { get; set; }
        [BindProperty]
        public int TypeDeviceId { get; set; }
        [BindProperty]
        public DateTime DeliveryDate { get; set; }
        [BindProperty]
        public DateTime? RepairDate { get; set; }

        [Required]
        [BindProperty]
        public string Address { get; set; }

        [Required]
        [BindProperty]
        public string Mail { get; set; }

        [Required]
        [BindProperty]
        public string Phone { get; set; }


        [BindProperty]
        public string Note { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            servis = new OrnekServis();
          
            this.TypeDeviceList = servis.GetTypeDeviceDto();
            OrgUnitList = servis.GetOrganizationUnitDto();
            TypeIssueList = servis.GetTypeIssueDto();
        }

        public void OnGet()
        {
            this.OrnekList = servis.Test();
        }

        public void OnPost()
        {


            //İnputların name kısmını kullanarak erişebiliyoruz 
            //örn=Note=Request.Form["note"], İndexin içindeki inputun name kısmı
            //var dto = new IssueDto()
            //{
            //    Note=Request.Form["note"],
            //    DeliveryDate=Convert.ToDateTime(Request.Form["GivenDate"].ToString()),
            //    Mail=this.Mail,
            //    Phone=this.Phone,
            //    Address = this.Address,
            //    UserId=1,
            //    Delivered=2,
            //    Giver=3,  
            //    RepairCustomer=4,
            //    RepairDate=Convert.ToDateTime("19-08-2021"),
            //    TypeDeviceId=Int32.Parse(Request.Form["DeviceTypeSelect"]),
            //    TypeIssueId= Int32.Parse(Request.Form["IssueTypeSelect"])
            //};


            var dtodnm = new IssueDto()
            {
                //This kullanmaya gerek yok fakat kodun anlaşılabilir olması ve karışmaması için kullanıyoruz
                Note=this.Note,
                Address=this.Address,
                Mail=this.Mail,
                Phone=this.Phone,

                // User tablomuz olmadığı için id bilgilerini elle giriyorum & tamamlanma tarihi manuel girdim
                UserId = 1,
                Delivered = 2,
                Giver = 3,
                RepairCustomer = 4,
                RepairDate = Convert.ToDateTime("10-09-2021"),
                //Şuanda html helper kullanmadan yaptığım için listeden seçtirerek aldığım objeler

                TypeDeviceId=this.TypeDeviceId,
                TypeIssueId=this.TypeIssueId,
                DeliveryDate=this.DeliveryDate
                //TypeDeviceId = Int32.Parse(Request.Form["DeviceTypeSelect"]),
                //TypeIssueId= Int32.Parse(Request.Form["IssueTypeSelect"]),
                //DeliveryDate = Convert.ToDateTime(Request.Form["GivenDate"].ToString()),

            };
            servis.PostIssue(dtodnm);
        }
    }
}
