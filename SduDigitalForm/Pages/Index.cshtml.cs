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

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var servis = new OrnekServis();
            this.OrnekList = servis.Test();

            this.TypeDeviceList = servis.GetTypeDeviceDto();
            OrgUnitList = servis.GetOrganizationUnitDto();
            TypeIssueList = servis.GetTypeIssueDto();

        }

        public void OnPost()
        {
            var t = Request;
            var dto = new TypeDeviceDto()
            {
                Name = Request.Form["Name"],

            };
           
        }
    }
}
