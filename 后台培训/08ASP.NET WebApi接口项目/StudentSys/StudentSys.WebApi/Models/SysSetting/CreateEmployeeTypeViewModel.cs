using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentSys.WebApi.Models.SysSetting
{
    public class CreateEmployeeTypeViewModel
    {
        [Required]
        [StringLength(maximumLength:20, MinimumLength =2)]
        public string Name { get; set; }
    }
}