using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITLA_Tarea1.Models
{
    public class Equipo
    {
        [Key]
        public int EquipoId { get; set; }

        [Required(ErrorMessage = "The Field {0} Is Required!")]
        [MaxLength(50, ErrorMessage = "The Field {0} must be maximun {1} Characters length!")]
        [Display(Name = "Equipo")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Field {0} Is Required!")]
        [Range(1, double.MaxValue, ErrorMessage = "You must select a {0}")]
        [Display(Name = "Division")]
        public int DivisionId { get; set; }


        [Required(ErrorMessage = "The Field {0} Is Required!")]
        [MaxLength(50, ErrorMessage = "The Field {0} must be maximun {1} Characters length!")]
        [Display(Name = "Localización")]
        public string Localization { get; set; }


        [Required(ErrorMessage = "The Field {0} Is Required!")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Año")]
        public DateTime Year { get; set; }

        public virtual Division Division { get; set; }


    }
}