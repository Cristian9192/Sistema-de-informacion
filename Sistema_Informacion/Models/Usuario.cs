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

        [Required(ErrorMessage = "ERROR CAMPO VACIO")]
        public int Documento { get; set; }

        [Required(ErrorMessage = "ERROR CAMPO VACIO")]
        public string TipoDocumento { get; set; }

        [Required(ErrorMessage = "ERROR CAMPO VACIO")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "ERROR CAMPO VACIO")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "ERROR CAMPO VACIO")]
        public string Email { get; set; }

        [Required(ErrorMessage = "ERROR CAMPO VACIO")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "ERROR CAMPO VACIO")]
        public bool Aprendiz { get; set; }

        [Required(ErrorMessage = "ERROR CAMPO VACIO")]
        public bool Egresado { get; set; }

        [Required(ErrorMessage = "ERROR CAMPO VACIO")]
        public string AreaFormacion { get; set; }

        [Required(ErrorMessage = "ERROR CAMPO VACIO")]
        public DateTime FechaEgresado { get; set; }

        [Required(ErrorMessage = "ERROR CAMPO VACIO")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "ERROR CAMPO VACIO")]
        public string Barrio { get; set; }

        [Required(ErrorMessage = "ERROR CAMPO VACIO")]
        public string Ciudad { get; set; }

        [Required(ErrorMessage = "ERROR CAMPO VACIO")]
        public string Departamento { get; set; }

        [Required(ErrorMessage = "ERROR CAMPO VACIO")]
        public DateTime FechaRegistro { get; set; }

    }
}