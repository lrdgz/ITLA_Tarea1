using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITLA_Tarea1.Models
{
    public class Division
    {
        [Key]
        public int DivisionId { get; set; }

        [Required(ErrorMessage = "The Field {0} Is Required!")]
        [MaxLength(50, ErrorMessage = "The Field {0} must be maximun {1} Characters length!")]
        [Display(Name = "Division")]
        public string Name { get; set; }


        public virtual ICollection<Equipo> Equipos { get; set; }
    }
}