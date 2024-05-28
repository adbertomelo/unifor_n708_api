using System.ComponentModel.DataAnnotations.Schema;

namespace bolao10.api.DataBase.Entities
{
    [Table("TIMES")]
    public class Time
    {
        public virtual int Id { get; set; }

        public virtual string Nome { get; set; }

        public virtual string Sigla { get; set; }

        public virtual string Figura { get; set; }

        public Time()
        {

        }

        public Time(string nome)
        {
            Nome = nome;
        }

    }
}
