using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SduDigitalForm.Business;
using SduDigitalForm.Business.Dto;
using System;
using System.Collections.Generic;
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

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            servis = new OrnekServis();
        }

        public void OnGet()
        {
            this.OrnekList = servis.Test();
            this.TypeDeviceList = servis.GetTypeDeviceDto();
            OrgUnitList = servis.GetOrganizationUnitDto();
            TypeIssueList = servis.GetTypeIssueDto();
        }

        public void OnPost()
        {
            var dto = new IssueDto()
            {
                Note = Request.Form["Note"],
                DeliveryDate=Convert.ToDateTime(Request.Form["GivenDate"].ToString()),
                Mail=Request.Form["Email"],
                Phone=Request.Form["Phone"],
                Address = Request.Form["Address"],
                UserId=1,
                Delivered=2,
                Giver=3,  
                RepairCustomer=4,
                RepairDate=Convert.ToDateTime("19-08-2021"),
                TypeDeviceId=Int32.Parse(Request.Form["DeviceTypeSelect"]),
                TypeIssueId= Int32.Parse(Request.Form["IssueTypeSelect"])
            };
            servis.PostIssue(dto);
        }
    }
}
