using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMSEntityLayer.Models
{
    public class City:Base<byte>
    {
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "İl adı en az 2 en fazla 50 karakter aralığında olmalıdır!")]
        public string CityName { get; set; }


        [Required]
        //TO DO: IsUnique

        public byte PlateCode { get; set; }
        //İlişkiler kurulacak.
        public virtual ICollection<District> Districts { get; set; }
        //Yukarıdakini kullanırsak .ToList()yapmak gerekiyor.
        //Eriniyorsak.ToList()yazmak yerine...

    }
}
