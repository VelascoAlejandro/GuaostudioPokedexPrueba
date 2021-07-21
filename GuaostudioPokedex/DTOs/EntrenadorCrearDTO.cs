using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuaostudioPokedex.DTOs
{
    public class EntrenadorCrearDTO
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 200)]
        public string Nombre { get; set; }
        [StringLength(maximumLength: 10)]
        public string Sexo { get; set; }
    }
}
