using SduDigitalForm.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SduDigitalForm.Business.Dto
{
    public class IssueDto
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int TypeIssueId { get; set; }

        public int RepairCustomer { get; set; }

        public int Delivered { get; set; }

        public int Giver { get; set; }

        public int TypeDeviceId { get; set; }

        public DateTime DeliveryDate { get; set; }

        public DateTime? RepairDate { get; set; }

        public string Address { get; set; }

        public string Mail { get; set; }

        public string Phone { get; set; }

        public string Note { get; set; }

    }
}
