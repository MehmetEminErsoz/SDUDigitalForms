using Microsoft.AspNetCore.Mvc;
using SduDigitalForm.Business.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SduDigitalForm.Areas.TeknikServisTalepFormu.Models
{
    public class TeknikServisTalepFormuViewModel
    {

      

        [BindProperty]
        public int Id { get; set; }
        [BindProperty]
        public int UserId { get; set; }
        [BindProperty]
        public int TypeIssueId { get; set; }
        [BindProperty]
        public int RepairCustomer { get; set; }
        [BindProperty]
        public int Delivered { get; set; }
        [BindProperty]
        public int Giver { get; set; }
        [BindProperty]
        public int TypeDeviceId { get; set; }
        [BindProperty]
        public DateTime DeliveryDate { get; set; }
        [BindProperty]
        public DateTime? RepairDate { get; set; }

        [Required]
        [BindProperty]
        public string Address { get; set; }

        [Required]
        [BindProperty]
        public string Mail { get; set; }

        [Required]
        [BindProperty]
        public string Phone { get; set; }


        [BindProperty]
        public string Note { get; set; }



    }
}
