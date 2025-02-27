using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ProyectoC1.Models
{
    public class Alumno
    {
        #region Propiedades
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AlumnoId { get; set; }

        [NotNull]
        public string Nombres { get; set; }

        [NotNull]
        public string Apellidos { get; set; }

        [NotNull]
        public int Edad { get; set; }

        [NotNull]
        public string Carnet { get; set; }
        public int CantidadMaterias { get; set; }
        public int Ciclo { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }

        [NotMapped]
        public string NombreCompleto => $"{Nombres} {Apellidos}";
        #endregion Propiedades

        #region Constructor
        public Alumno(string nombres, int edad, string apellidos, DateTime fechaNacimiento)
        {
            Nombres = nombres;
            Edad = edad;
            Apellidos = apellidos;
            FechaNacimiento = fechaNacimiento;
        }
        #endregion Constructor

        #region Funciones
        public int CalcularEdad()
        {
            var hoy = DateTime.Today;
            var edad = hoy.Year - FechaNacimiento.Year;
            if (FechaNacimiento.Date > hoy.AddYears(-edad)) edad--;
            return edad;
        }
        #endregion Funciones
    }
}