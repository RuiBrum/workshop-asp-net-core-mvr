using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace webCourse.Models
{
 [Table("usuarios")]
 public class Usuarios {
   [Key]
   [Display(Name="Id")]
   public int id { get; set; }
   [Required]
   [StringLength(1)]
   [Display(Name="Id_Tabelionato")]
   public string id_tabelionato { get; set; }
   [Display(Name="Nome")]
   public string nome { get; set; }
   [Display(Name="Login")]
   public string login { get; set; }
   [Display(Name="Senha")]
   public string senha { get; set; }
   [Required]
   [StringLength(1)]
   [Display(Name="Status")]
   public string status { get; set; }
   [StringLength(5)]
   [MinLength(5)]
   [Display(Name="Aniversario")]
   public string aniversario { get; set; }
 }
}
