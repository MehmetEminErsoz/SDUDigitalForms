using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SduDigitalForm.Business.Dto
{
    public class TypeIssueDto
    {

        [Key]
        public int Idissue { get; set; }
        public string IssueType { get; set; }
    }
}
