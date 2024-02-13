using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploDataAccessEntityFrameworkDataAnnotations.Models
{
    //Informando o nome da tabela que é referente ao objeto no banco
    [Table("Role")]
    public class Role
    {
        [Key] //Informando que essa propriedade é a chave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Informando que a chave primaria é gerada automaticamente no banco
        public int Id { get; set; }

        [Required]//Infromando que o campo é NotNull
        [MinLength(3)] //Informando a quantidade de caracteres minima no campo
        [MaxLength(80)] //Informando a quantidade de caracteres limites no campo
        [Column("Name", TypeName = "VARCHAR")] //Expecificando o tipo do campo no banco de dados "[Column("NomeCampo", TypeName = "NomeTipo")]"
        public string Name { get; set; }

        [Required]//Infromando que o campo é NotNull
        [MinLength(3)] //Informando a quantidade de caracteres minima no campo
        [MaxLength(80)] //Informando a quantidade de caracteres limites no campo
        [Column("Slug", TypeName = "VARCHAR")] //Expecificando o tipo do campo no banco de dados "[Column("NomeCampo", TypeName = "NomeTipo")]"
        public string Slug { get; set; }
    }
}
