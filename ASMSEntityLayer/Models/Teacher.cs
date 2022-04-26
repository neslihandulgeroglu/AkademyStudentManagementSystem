using ASMSEntityLayer.IdentityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMSEntityLayer.Models
{
    class Teacher
    {
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual AppUser AppUser {get;set;}


    }
}
