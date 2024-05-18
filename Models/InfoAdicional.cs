using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChurnAnalitycs.Models
{
    public class InfoAdicional
    {
        [Key]
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; } 


        [StringLength(100)]
        [Display(Name = "Nome da Integração de Sistema")]
        public string NomeIntegracaoSistema { get; set; }

        [StringLength(1000)]
        [Display(Name = "Informações sobre Produtos/Serviços")]
        public string InfoProdutosServicos { get; set; }

        [StringLength(1000)]
        [Display(Name = "Outras Informações Específicas do Setor")]
        public string OutrasInformacoesSetor { get; set; }

        [StringLength(500)]
        [Display(Name = "Segmentação de Clientes")]
        public string SegmentacaoClientes { get; set; }

        [StringLength(500)]
        [Display(Name = "Persona do Cliente")]
        public string PersonaCliente { get; set; }

        [StringLength(500)]
        [Display(Name = "Estrutura Organizacional")]
        public string EstruturaOrganizacional { get; set; }

        [StringLength(500)]
        [Display(Name = "Informações Regulatórias e de Conformidade")]
        public string InformacoesRegulatoriasConformidade { get; set; }

        [StringLength(500)]
        [Display(Name = "Objetivos e Metas Estratégicas")]
        public string ObjetivosMetasEstrategicas { get; set; }
    }
}
