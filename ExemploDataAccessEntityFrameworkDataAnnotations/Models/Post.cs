using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploDataAccessEntityFrameworkDataAnnotations.Models
{
    //Informando o nome da tabela que é referente ao objeto no banco
    [Table("Post")]
    public class Post
    {
        [Key] //Informando que essa propriedade é a chave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Informando que a chave primaria é gerada automaticamente no banco
        public int Id { get; set; }

        [Required]//Infromando que o campo é NotNull
        [MinLength(3)] //Informando a quantidade de caracteres minima no campo
        [MaxLength(160)] //Informando a quantidade de caracteres limites no campo
        [Column("Title", TypeName = "VARCHAR")] //Expecificando o tipo do campo no banco de dados "[Column("NomeCampo", TypeName = "NomeTipo")]"
        public string Title { get; set; }

        [Required]//Infromando que o campo é NotNull
        [MinLength(3)] //Informando a quantidade de caracteres minima no campo
        [MaxLength(255)] //Informando a quantidade de caracteres limites no campo
        [Column("Summary", TypeName = "VARCHAR")] //Expecificando o tipo do campo no banco de dados "[Column("NomeCampo", TypeName = "NomeTipo")]"
        public string Summary { get; set; }

        [Required]//Infromando que o campo é NotNull
        [MinLength(3)] //Informando a quantidade de caracteres minima no campo
        [Column("Body", TypeName = "TEXT")] //Expecificando o tipo do campo no banco de dados "[Column("NomeCampo", TypeName = "NomeTipo")]"
        public string Body { get; set; }

        [Required]//Infromando que o campo é NotNull
        [MinLength(3)] //Informando a quantidade de caracteres minima no campo
        [MaxLength(80)] //Informando a quantidade de caracteres limites no campo
        [Column("Slug", TypeName = "VARCHAR")] //Expecificando o tipo do campo no banco de dados "[Column("NomeCampo", TypeName = "NomeTipo")]"
        public string Slug { get; set; }

        [Required]//Infromando que o campo é NotNull
        [Column("CreateDate", TypeName = "DATETIME")] //Expecificando o tipo do campo no banco de dados "[Column("NomeCampo", TypeName = "NomeTipo")]"
        public DateTime CreateDate { get; set; }

        [Required]//Infromando que o campo é NotNull
        [Column("LastUpdateDate", TypeName = "DATETIME")] //Expecificando o tipo do campo no banco de dados "[Column("NomeCampo", TypeName = "NomeTipo")]"
        public DateTime LastUpdateDate { get; set; }

        [ForeignKey("CategoryId")] //Informando que se trata de uma chave estrangeira
        public int CategoryId { get; set; }

        public Category Category { get; set; } //Referenciando a qual objetó é a chave estrangeira acima

        [ForeignKey("AuthorId")] //Informando que se trata de uma chave estrangeira
        public int AuthorId { get; set; }

        public User Author { get; set; } //Referenciando a qual objetó é a chave estrangeira acima
    }
}
