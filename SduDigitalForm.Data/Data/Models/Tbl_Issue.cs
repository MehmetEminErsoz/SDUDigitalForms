using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SduDigitalForm.Data.Data.Models
{
    public class Tbl_Issue
    {
        public int Id { get; set; }

        //Cihaz Sahibi
        public int UserId { get; set; }
     
        public int TypeIssueId { get; set; }
        [ForeignKey("TypeIssueId")]
        public Tbl_IssueType TypeIssue { get; set; }

        //Onarım İsteyen
        public int RepairCustomer { get; set; }

        //Teslim Alan 
        public int Delivered { get; set; }

        //Teslim Eden
        public int Giver { get; set; }

        
        public int TypeDeviceId { get; set; }
        [ForeignKey("TypeDeviceId")]
        public Tbl_TypeDevice TypeDevice { get; set; }

        public DateTime DeliveryDate { get; set; }

        public DateTime? RepairDate { get; set; }

        public string Address{ get; set; }

        public string Mail{ get; set; }

        public string Phone { get; set; }

        public string Note { get; set; }

    }
}
