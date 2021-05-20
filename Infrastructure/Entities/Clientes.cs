using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Infrastructure.Entities
{
    public class Clientes
    {
        [Required(ErrorMessage = "Campo obligatorio. Ingrese su nombre.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo obligatorio. Ingrese su apellido.")]
        public string Apellido { get; set; }

        [Key]
        [Required(ErrorMessage = "Campo obligatorio. Digite su documento de identificación.")]
        [Range(6, 10, ErrorMessage = "Cedula entre 6 a 10 digitos.")]
        public int Identificacion { get; set; }

        public string Direccion { get; set; }
    }
}
