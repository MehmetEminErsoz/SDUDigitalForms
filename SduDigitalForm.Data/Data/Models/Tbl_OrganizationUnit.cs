using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SduDigitalForm.Data.Data.Models
{
    public class Tbl_OrganizationUnit
    {
        public int Id { get; set; }
        public int DisplayName { get; set; }
        public int? ParentId { get; set; }

        [ForeignKey("ParentId")]
        public Tbl_OrganizationUnit Parent { get; set; }
    }
}
