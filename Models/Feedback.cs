using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChurnAnalitycs.Models
{
    public class Feedback
    {
        [Key]
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }


        [Display(Name = "Data do Feedback")]
        public DateTime? DataFeedback { get; set; }

        [StringLength(100)]
        [Display(Name = "Indicador de Desempenho")]
        public string IndicadorDesempenho { get; set; }

        [Display(Name = "Valor do Indicador")]
        public int ValorIndicador { get; set; }

        [Column("TipoInteracao")]
        [Display(Name = "Tipo de Interação")]
        public string TipoInteracao { get; set; }

        [StringLength(50)]
        [Display(Name = "Nome do Canal de Comunicação")]
        public string NomeCanalComunicacao { get; set; }

        [Display(Name = "Data do Atendimento")]
        public DateTime? DataAtendimento { get; set; }

        [StringLength(50)]
        [Display(Name = "Tipo de Atendimento")]
        public string TipoAtendimento { get; set; }

        [StringLength(500)]
        [Display(Name = "Resolução do Problema")]
        public string ResolucaoProblema { get; set; }
    }
}
