using System.ComponentModel.DataAnnotations.Schema;

namespace bolao10.api.DataBase.Entities
{
    [Table("BOLOES")]
    public class Bolao
    {

        public virtual int Id { get; set; }

        public virtual string Descricao { get; set; }

        public virtual int NumMaxParticipantes { get; set; }

        public virtual decimal Valor { get; set; }

        public virtual int Situacao { get; set; }

        [Column("DATA_INICIO")]
        public virtual DateTime DataInicio { get; set; }

        public Bolao()
        {
        }

        public Bolao(string descricao, int nummaxparticipantes, decimal valor, int situacao)
        {
            this.Descricao = descricao;
            this.NumMaxParticipantes = nummaxparticipantes;
            this.Valor = valor;
            this.Situacao = situacao;
        }
   
    }
}
