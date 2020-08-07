using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace riplegal.api.Models.Submodulo
{
    public class SubmoduloViewModel
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public Guid IdModulo { get; set; }
    }
}
