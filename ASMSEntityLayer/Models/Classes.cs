using ASMSEntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMSEntityLayer.Models
{
    public class Classes
    {
        [Required]
        [StringLength(50,MinimumLength =2,ErrorMessage=)]
        public string  ClassName{ get; set; }
        public ClassLocation Classfloor { get; set; }
    }
}
