
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex.Models
{
   
    public class Pokemon
    {
        [Key]
        
        public int Id { get; set; }

        public string Foto { get; set; }

        [Required(ErrorMessage ="El Nombre del pokemon es obligatorio ")]
        [StringLength(50, ErrorMessage = "Debe de tener minimo 3 caracteres", MinimumLength = 3)]
        [Display(Name ="Pokemon")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El tipo del pokemon es obligatorio ")]
        [StringLength(50, ErrorMessage = "Debe de tener minimo 3 caracteres", MinimumLength = 3)]
        [Display(Name = "Tipo Primario")]
        public  string Primario { get; set; }

        [Required(ErrorMessage = "El tipo del pokemon es obligatorio ")]
        [StringLength(50, ErrorMessage = "Debe de tener minimo 3 caracteres", MinimumLength = 3)]
        [Display(Name = "Tipo Secundario")]
        public string Secundario { get; set; }

        [Required(ErrorMessage = "La Region del pokemon es obligatoria ")]
        [StringLength(50, ErrorMessage = "Debe de tener minimo 3 caracteres", MinimumLength = 3)]
        [Display(Name = "Region")]
        public string Region { get; set; }

    }
}
