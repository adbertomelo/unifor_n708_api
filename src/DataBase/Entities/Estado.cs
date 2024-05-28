using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bolao10.api.DataBase.Entities
{

    [Table("ESTADOS")]
    public class Estado
    {
        
        public int Id { get;  set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        [ForeignKey("PAIS_ID")]
        public Pais Pais { get; set; }

    }
}
