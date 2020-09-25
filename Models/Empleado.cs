using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElCondor.Models
{
    public class Empleado
    {
        [Key]
        public int IdEmpleado { get; set; }

        [Display (Name = "Tipo de documento")]
        [Required(ErrorMessage = "El tipo de documento es requerido")]
        [StringLength(50, ErrorMessage = "Longitud máxima para el tipo de documento es 50")]        
        public string TipoDocumento { get; set; }

        [Display(Name = "Número de documento")]        
        [Range(1000000, int.MaxValue, ErrorMessage = "Revise su número de documento")]
        public int NúmeroDocumento { get; set; }

        [Display(Name = "Nombres")]
        [Required(ErrorMessage = "Nombres es requerido")]
        [StringLength(50, ErrorMessage = "Longitud máxima para los nombres es 50")]
        public string Nombres { get; set; }

        [Display(Name = "Apellidos")]
        [Required(ErrorMessage = "Los apellidos es requerido")]
        [StringLength(50, ErrorMessage = "Longitud máxima para los apellidos es 50")]
        public string Apellidos { get; set; }
                
        [Display(Name = "Fecha De Nacimiento yyyy-MM-dd")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? FechaDeNacimiento { get; set; }

        [Display(Name = "Area a la que pertenece")]
        [Required(ErrorMessage = "La área a la que pertenece es requerida")]
        [StringLength(50, ErrorMessage = "Longitud máxima para la área a la que pertenece es 50")]
        public string AreaALaQuePertenece { get; set; }

    }
}
