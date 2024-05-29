using AutoMapper.Configuration.Annotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bolao10.api.DataBase.Entities
{
    [Table("JOGOS")]
    public class Jogo
    {

        public virtual int Id { get; set; }

        [ForeignKey("RODADA_ID")]
        public virtual Rodada Rodada { get; set; }

        [ForeignKey("TIME1_ID")]
        public virtual Time Time1 { get; set; }

        public virtual int? Gols1 { get; set; }

        [Column("GOLS1_REALTIME")]
        public virtual int? Gols1RealTime { get; set; }

        [ForeignKey("TIME2_ID")]
        public virtual Time Time2 { get; set; }

        
        public virtual int? Gols2 { get; set; }

        [Column("GOLS2_REALTIME")]
        public virtual int? Gols2RealTime { get; set; }

        public virtual DateTime Dia { get; set; }

        [NotMapped]
        public virtual DateTime DiaUTC { get; set; }

        public virtual string Local { get; set; }

        public virtual bool Hoje
        {
            get
            {
                return this.Dia.Date == DateTime.Now.Date;
            }

        }

        
        public virtual bool Amanha
        {
            get
            {
                return this.Dia.Date > DateTime.Now.Date;
            }

        }


        [NotMapped]
        public virtual string Codigo { get; set; }

        public Jogo()
        {

        }

        public Jogo(string codigo, Time time1, Time time2, int? gols1RealTime, int? gols2RealTime)
        {
            Codigo = codigo;
            Time1 = time1;
            Time2 = time2;
            Gols1RealTime = gols1RealTime;
            Gols2RealTime = gols2RealTime;
        }

    }
}
