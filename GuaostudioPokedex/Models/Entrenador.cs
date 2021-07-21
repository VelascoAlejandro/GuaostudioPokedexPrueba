using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuaostudioPokedex.Models
{
    public class Entrenador
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="El campo {0} es requerido")]
        [StringLength(maximumLength:200)]
        public string Nombre { get; set; }
        [StringLength(maximumLength: 10)]
        public string Sexo { get; set; }
        [DefaultValue(true)]
        public bool Activo { get; set; } = true;
    }
}
