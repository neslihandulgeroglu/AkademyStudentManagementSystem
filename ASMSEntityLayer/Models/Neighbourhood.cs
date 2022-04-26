using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMSEntityLayer.Models
{
    public class Neighbourhood:Base<int>
    {
        [Required]
        [StringLength(50,MinimumLength =2,ErrorMessage="" +
            "Mahalle adı en az 2 en fazla 50 karakter aralığında olmalıdır.")]
        public string NeighbourhoodName { get; set; }
        public int DistrictId { get; set; }
        [ForeignKey("DistricId")]
        public virtual District District { get; set; }
        public virtual ICollection<UsersAddress> UsersAddresses { get; set; }



    }
}
