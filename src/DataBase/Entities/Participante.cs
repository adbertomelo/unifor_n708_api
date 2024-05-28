using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bolao10.api.DataBase.Entities
{

    [Table("PARTICIPANTES")]
    public class Participante
    {
        public virtual int Id { get; set; }

        [ForeignKey("USUARIO_ID")]
        public virtual Usuario Usuario { get; set; }

        [ForeignKey("BOLAO_ID")]
        public virtual Bolao Bolao { get; set; }
        
        [Column("DATAHORA_ACESSO")]
        public virtual DateTime? DataHoraAcesso { get; set; }
        
        [Column("DATAHORA_ULTIMO_ACESSO")]
        public virtual DateTime? DataHoraUltimoAcesso { get; set; }
        
        [Column("NUM_ACESSOS")]
        public virtual int? NumAcessos { get; set; }
        
        public virtual int? Status { get; set; }
        [Column("SITUACAO_PAGAMENTO")]
        
        public virtual int? SituacaoPagamento { get; set; }
        public virtual string? Convida { get; set; }
        public virtual string? Tipo { get; set; }
        public virtual string? Cor { get; set; }
        [Column("NUM_BOLOES_PARTICIPOU")]
        public virtual int? NumBoloesParticipou { get; set; }
        [Column("MELHOR_POSICAO_BOLOES_PASSADOS")]
        public virtual int? MelhorColocacaoBoloesPassados { get; set; }
        
        [Column("NOME_BOLAO_MELHOR_POSICAO")]
        public virtual string? NomeBolaoMelhorColocacao { get; set; }

        public virtual string? Codigo { get; set; }
        [Column("POSICAO_ATUAL")]
        public virtual int? PosicaoAtual { get; set; }
        [Column("MELHOR_POSICAO_DIA")]
        public virtual int? MelhorPosicaoDia { get; set; }
        [Column("POSICAO_ONLINE")]
        public virtual int? PosicaoOnline { get; set; }
        [Column("NUM_APOSTAS_RODADA_CORRENTE_OK")]
        public virtual string? NumApostaRodadaCorrenteOk { get; set; }
        
        [Column("NOME_BOLOES_PARTICIPOU")]
        public virtual string? NomeBoloesParticipou { get; set; }
        [Column("ID_TIME_CAMPEAO")]
        public virtual int? TimeCampeao { get; set; }
        
        [Column("ID_PARTICIPANTE_QUE_CONVIDOU")]
        public virtual int? IdConvidador { get; set; }
        [Column("NUM_PONTOS")]
        public virtual int? NumPontos { get; set; }
        [Column("POSICAO_ANTERIOR")]
        public virtual int? PosicaoAnterior { get; set; }
        
        //public virtual IList<Comentario> Comentarios { get; set; }

        public Participante()
        {
            //Comentarios = [];
        }

        //public Participante()
        //{ }
        //public Participante(Usuario usuario, Bolao bolao)
        //{
        //    this.Tipo = "U";
        //    this.NumApostaRodadaCorrenteOk = "N";
        //    this.Convida = "S";
        //    this.Usuario = usuario;
        //    this.Bolao = bolao;
        //    this.Codigo = Guid.NewGuid().ToString();
        //    this.SituacaoPagamento = 0;
        //}

        //public virtual Comentario AdicionarComentario(Comentario comentario)
        //{
        //    comentario.Participante = this;
        //    comentario.Ordem = Comentarios.Count + 1;
        //    Comentarios.Add(comentario);
        //    return comentario;
        //}

    }

}
