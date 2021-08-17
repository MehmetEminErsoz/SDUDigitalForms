using SduDigitalForm.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SduDigitalForm.Business.Dto
{
    public class OrganizationUnitDto
    {

        public int Id { get; set; }
        public String DisplayName { get; set; }
        public int? ParentId { get; set; }

        [ForeignKey("ParentId")]
        public Tbl_OrganizationUnit Parent { get; set; }
    }
}
