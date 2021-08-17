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

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var servis = new OrnekServis();
            this.OrnekList = servis.Test();

            this.TypeDeviceList = servis.GetTypeDeviceDto();
        }
    }
}
