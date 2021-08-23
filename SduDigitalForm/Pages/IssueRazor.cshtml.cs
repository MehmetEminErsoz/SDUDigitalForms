using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SduDigitalForm.Business;
using SduDigitalForm.Business.Dto;
using System.ComponentModel.DataAnnotations;

namespace SduDigitalForm.Pages
{
    public class IssueRazorModel : PageModel
    {

        private readonly ILogger<IssueRazorModel> _logger;
        public List<IssueDto> ýssueDtos;
        public List<TypeDeviceDto> TypeDeviceList;
        public List<OrganizationUnitDto> OrgUnitList;
        public List<TypeIssueDto> TypeIssueList;
        private readonly OrnekServis servis;

        public string name { get; set; }
        public IssueRazorModel(ILogger<IssueRazorModel> logger)
        {
            _logger = logger;
            servis = new OrnekServis();
            this.TypeDeviceList = servis.GetTypeDeviceDto();
            OrgUnitList = servis.GetOrganizationUnitDto();
            TypeIssueList = servis.GetTypeIssueDto();
        }

        public void OnGet()
        {
            this.ýssueDtos = servis.GetIssues();

        }

        public void OnPost()
        {

        }


    }
}
