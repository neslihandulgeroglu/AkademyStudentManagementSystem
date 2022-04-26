using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMSEntityLayer.IdentityModels
{
    class AppRole:IdentityRole
    {
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        [StringLength(500.ErrorMessage="Role açıklaması en  fazla 500 karakter olmaldır!")]
        public string Descrioption { get; set; }
        public bool IsDeleted { get; set; } = false;

    }
}
