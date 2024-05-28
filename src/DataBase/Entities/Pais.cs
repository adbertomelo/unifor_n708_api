using System.ComponentModel.DataAnnotations.Schema;

namespace bolao10.api.DataBase.Entities
{

    [Table("PAISES")]
    public class Pais
    {
        public int Id { get; set; }
        public string Nome { get; set; }

    }
}
