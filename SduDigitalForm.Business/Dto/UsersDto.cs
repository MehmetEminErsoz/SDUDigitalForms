using SduDigitalForm.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SduDigitalForm.Business.Dto
{
    public class UsersDto
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
       

     
        public int OrganizationUnitId { get; set; }
        [ForeignKey("Id")]
        public Tbl_OrganizationUnit Tbl_OrganizationUnit { get; set; }
    }
}
