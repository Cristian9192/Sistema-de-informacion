using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Sistema_Informacion.Models
{
    public class Usuario
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "El documento es obligatorio")]
        public string Documento { get; set; }

        [Required(ErrorMessage = "El tipo documento es obligatorio")]
        public string TipoDocumento { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El celular es obligatorio")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "El email es obligatorio")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El genero es obligatorio")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "El aprendiz es obligatorio")]
        public int Aprendiz { get; set; }

        [Required(ErrorMessage = "El egresado es obligatorio")]
        public int Egresado { get; set; }

        [Required(ErrorMessage = "El Area de formacion es obligatorio")]
        public string AreaFormacion { get; set; }

        public DateTime FechaEgresado { get; set; }

        [Required(ErrorMessage = "La direccion es obligatoria")]

        public string Direccion { get; set; }

        [Required(ErrorMessage = "El Barrio es obligatorio")]

        public string Barrio { get; set; }

        [Required(ErrorMessage = "El Ciudad es obligatorio")]

        public string Ciudad { get; set; }

        [Required(ErrorMessage = "El Departamento es obligatorio")]
        public string Departamento { get; set; }

        [Required(ErrorMessage = "El Fecha Registro es obligatorio")]
        public DateTime FechaRegistro { get; set; }

    }
}