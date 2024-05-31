using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bolao10.api.DataBase.Entities
{
    [Table("PARAMETROS")]
    public class Parametros
    {

        [Key]
        public virtual Int64 Id { get; set; }

        [Column("TIME_ID")]
        public virtual int TimeID { get; set; }

        [Column("NUM_DIAS_INADIMPLENCIA")]
        public virtual int NumDiasInadimplencia { get; set; }
        
        [Column("EMAIL_ADMIN")]
        public virtual string EmailAdmin { get; set; }
        
        [Column("DATA_INICIAL_CONVITES")]
        public virtual DateTime DataInicialConvites { get; set; }
        
        [Column("DATA_FINAL_CONVITES")]
        public virtual DateTime DataFinalConvites { get; set; }
        
        [Column("NOME_ARQUIVO_REGRAS")]
        public virtual string NomeArquivoRegras { get; set; }

        bool _PeriodoConvitesAberto;

        [NotMapped]
        public virtual bool PeriodoConvitesAberto
        {
            get
            {
                return DateTime.Now >= this.DataInicialConvites && DateTime.Now <= this.DataFinalConvites;
            }
            set { _PeriodoConvitesAberto = value; }
        }



    }
}
