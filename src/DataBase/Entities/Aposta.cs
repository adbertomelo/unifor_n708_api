using System.ComponentModel.DataAnnotations.Schema;

namespace bolao10.api.DataBase.Entities
{

    [Table("APOSTAS")]
    public class Aposta
    {

        public virtual int Id { get; set; }

        [ForeignKey("JOGO_ID")]
        public virtual Jogo Jogo { get; set; }

        [ForeignKey("PARTICIPANTE_ID")]
        public virtual Participante Participante { get; set; }

        public virtual int? Gols1 { get; set; }

        public virtual int? Gols2 { get; set; }

        public Aposta()
        {
        }

        public Aposta(Participante participante, Jogo jogo)
        {
            this.Participante = participante;
            this.Jogo = jogo;
        }



        
    }
}
