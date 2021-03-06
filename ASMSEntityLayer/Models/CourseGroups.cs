using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

sing System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMSEntityLayer.Models
{
    [Table("CourseGroups")]
    public class CourseGroup : Base<int>
    {
        public int ClassId { get; set; }
        //Öğretmen id gelecek
        public int CourseId { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime FinishDate { get; set; }
        public int Capasite { get; set; }

        [Required]
        [StringLength(7, MinimumLength = 7, ErrorMessage = "Kurs portal numarası 7 haneli olmalıdır!")]
        //TO DO : isUnique eklenecek.
        public string PortalCode { get; set; }  //1090997  1101064



    }
}
