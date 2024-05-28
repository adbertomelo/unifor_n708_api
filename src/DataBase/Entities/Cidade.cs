using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bolao10.api.DataBase.Entities
{
    [Table("CIDADES")]
    public class Cidade
    {
        
        public int Id { get; set; }

        public string Nome { get; set; }

        [ForeignKey("ESTADO_ID")]
        public   Estado Estado { get; set; }


    }
}
