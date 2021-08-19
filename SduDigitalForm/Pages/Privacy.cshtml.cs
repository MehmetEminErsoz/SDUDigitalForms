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


    
    public class PrivacyModel : PageModel
    {


        
        private readonly ILogger<PrivacyModel> _logger;
        public List<IssueDto> IssueList;
        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var servis = new OrnekServis();
            IssueList = servis.GetIssues();


        }
    }
}
