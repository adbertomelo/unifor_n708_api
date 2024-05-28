using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace bolao10.api.DataBase.Entities
{
    [Table("RODADAS")]
    public class Rodada
    {

        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        
        [Column("DATA_INICIAL")]
        public virtual DateTime DataInicial { get; set; }

        [Column("DATA_ENCERRAMENTO")]
        public virtual DateTime DataEncerramento { get; set; }

        [ForeignKey("FASE_ID")]
        public virtual Fase Fase { get; set; }
        public virtual int Status { get; set; }
        public virtual int Ordem { get; set; }
        public virtual bool Aberta
        {
            get
            {
                return (this.Status == 1);
            }

        }

        /*
        public virtual static Aposta[] FindAllApostas(int rodadaid, int participanteid)
        {

            string hql = "";

            hql = @"FROM Aposta a JOIN FETCH a.Jogo JOIN FETCH a.Jogo.Time1 JOIN FETCH a.Jogo.Time2 JOIN FETCH a.Participante WHERE a.Jogo.Rodada.Id = ? AND a.Participante.Id = ? ORDER BY a.Jogo.Id";

            SimpleQuery<Aposta> query = new SimpleQuery<Aposta>(hql, rodadaid, participanteid);

            Aposta[] apostas = query.Execute();

            return (apostas);
        }
        */

        /*
        public virtual static Rodada FindRodadaCorrente()
        {
            DateTime hoje = DateTime.Now;

            Rodada[] rodadas = (Rodada[])FindAll(typeof(Rodada), Restrictions.And(Restrictions.Lt("DataInicial", hoje), Restrictions.Gt("DataEncerramento", hoje)));

            if ( rodadas.Length > 0 )
                return rodadas[0];
            else
                return null;
        }
        */

        /*
        public virtual static Rodada FindRodadaCorrente()
        {
            Rodada[] rodadas = (Rodada[])FindAllByProperty(typeof(Rodada), "Status", 1);

            if (rodadas.Length > 0)
                return rodadas[0];
            else
                return null;
        }*/

        /*
        public virtual static JogoSimulador[] FindAllJogosByParticipanteAndRodada(int participanteid,int rodadaid)
        {
            return (JogoSimulador.FindAllByParticipanteAndRodada(participanteid, rodadaid));
        }
        */
        /*
        public virtual static Rodada[] FindAll()
        {
            return (Rodada[])FindAll(typeof(Rodada));
        }
        */
        /*
        public virtual static Rodada FindById(int id)
        {
            return (Rodada)FindByPrimaryKey(typeof(Rodada), id);
        }
         */

        //public virtual static ApostaSimulador[] FindAllJogos(int rodadaid, int participanteid)
        //{

        //    string hql = @"FROM ApostaJSON a WHERE a.RodadaID = ? AND a.ParticipanteID = ?";

        //    //hql = @"FROM Aposta a JOIN FETCH a.Jogo JOIN FETCH a.Jogo.Time1 JOIN FETCH a.Jogo.Time2 JOIN FETCH a.Participante WHERE a.Jogo.Rodada.Id = ? AND a.Participante.Id = ?";

        //    SimpleQuery<ApostaSimulador> query = new SimpleQuery<ApostaSimulador>(hql, rodadaid, participanteid);

        //    ApostaSimulador[] jogos = query.Execute();

        //    return (jogos);

        //}

        /*
        public virtual static Rodada FindByOrdem(int ordem)
        {
            return (Rodada)FindOne(typeof(Rodada), Restrictions.Eq("Ordem", ordem));
        }

        public virtual static Rodada[] FindByFase(int faseID)
        {
            
            Fase fase = Fase.FindById(faseID);

            return (Rodada[])FindAllByProperty(typeof(Rodada), "Fase", fase);

        }

        public virtual static Rodada[] FindAllAbertas()
        {
            return(Rodada[])FindAllByProperty(typeof(Rodada), "Status", 1);
        }*/

        public static dynamic FindByFase(int fasecorrente)
        {
            throw new NotImplementedException();
        }
    }
}
