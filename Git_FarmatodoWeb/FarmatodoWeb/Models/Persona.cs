using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmatodoWeb.Models
{
    [Table("persona")]
    public class Persona
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name="Usuario")]
        [Column("dni")]
        [Required(ErrorMessage="Por favor, ingrese su DNI.")]
        [Key]
        public int Id{get; set;}

        [Display(Name="Contraseña")]
        [Column("contrasena")]
        [Required(ErrorMessage="Por favor, ingrese su contraseña.")]
        [DataType(DataType.Password)]
        public string Contrasena{get; set;}

        [Display(Name="Nombre")]
        [Column("nombre")]
        [Required(ErrorMessage="Por favor, ingrese su nombre.")]
        public string Nombre{get; set;}

        [Display(Name="Ape. Paterno")]
        [Column("apellidopat")]
        [Required(ErrorMessage="Por favor, ingrese su apellido paterno.")]
        public string ApellidoPat{get; set;}

        [Display(Name="Ape. Materno")]
        [Column("apellidomat")]
        [Required(ErrorMessage="Por favor, ingrese su apellido materno.")]
        public string ApellidoMat{get; set;}

        [Display(Name="Género")]
        [Column("genero")]
        [Required(ErrorMessage="Por favor, ingrese su género.")]
        public string Genero{get; set;}

        [Display(Name="Foto")]
        [Column("foto")]
        [Required(ErrorMessage="Por favor, ingrese su foto.")]
        public string Foto{get; set;}

        [Display(Name="Rol")]
        [Column("rol")]
        //[Required(ErrorMessage="Por favor, ingrese su rol.")]
        public string Rol{get; set;}
        
//        public Categoria Categoria{get; set;}
//        [Display(Name="Categoría")]
//        [Column("id_categoria")]
//        public int CategoriaId{get; set;}

        // [NotMapped]
        // public string JavascriptToRun{get; set;}
    }
}