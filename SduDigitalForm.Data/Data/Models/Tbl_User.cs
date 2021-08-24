using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SduDigitalForm.Data.Data.Models
{
    public class Tbl_User : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }

        public int OrganizationUnitId { get; set; }
    }
}
