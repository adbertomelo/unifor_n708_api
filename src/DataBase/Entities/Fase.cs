using System.ComponentModel.DataAnnotations.Schema;

namespace bolao10.api.DataBase.Entities
{
    [Table("FASES")]
    public class Fase
    {
        public virtual int Id { get; set; }

        public virtual string Nome { get; set; }

        public virtual string Status { get; set; }
    }
}
