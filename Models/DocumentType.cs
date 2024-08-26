using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models;

[Table("documet_types")]
public class DocumentType
{
    [Key]
    public int Id { get; set; }
    [Column("name")]
    [MaxLength(50, ErrorMessage = "El campo Name tiene un valor maximo de 50 caracteres")]
    public required string Name { get; set; } //Obligatorio

    [Column("abbreviation")]
    [MaxLength(2, ErrorMessage = "El campo Abbreviation tiene un valor minimo de 2 caracteres")]
    [MinLength(10, ErrorMessage = "El campo Abbreviation tiene un valor maximo de 10 caracteres")]
    public required string Abbreviation { get; set; }//Obligatorio

    [Column("description")]
    [MaxLength(500, ErrorMessage = "El campo Description tiene un valor maximo de 500 caracteres")]

    public string? Description { get; set; }  //Opcional
}
