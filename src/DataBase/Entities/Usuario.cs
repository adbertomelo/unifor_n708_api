using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bolao10.api.DataBase.Entities
{

    [Table("USUARIOS")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }

        [Required]
        public string Email { get; set; }
        public string Sexo { get; set; }
        
        [ForeignKey("CIDADE_ID")]                
        public Cidade Cidade { get; set; }


        public Usuario()
        {
        }
        public Usuario(string nome, string email, Cidade cidade, string senha)
        {
            Nome = nome;
            Email = email;
            Cidade = cidade;
            Senha = senha;
        }
    }
}
