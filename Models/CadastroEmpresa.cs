using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ChurnAnalitycs.Models
{
    public class CadastroEmpresa
    {
        [Key]
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Column("RazaoSocial")]
        [Display(Name = "Razão Social")]
        public string RazaoSocial { get; set; }

        [Required]
        [StringLength(14)]
        [Column("CNPJ")]
        [Display(Name = "CNPJ")]
        public string CNPJ { get; set; }

        [Required]
        [StringLength(100)]
        [Column("SetorAtuacao")]
        [Display(Name = "Setor de Atuação")]
        public string SetorAtuacao { get; set; }

        [Required]
        [StringLength(50)]
        [Column("Porte")]
        [Display(Name = "Porte da Empresa")]
        public string Porte { get; set; }

        [Required]
        [Column("Endereco")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Required]
        [Column("Numero")]
        [Display(Name = "Número")]
        public string Numero { get; set; }

        [Column("Bairro")]
        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Required]
        [Column("Cidade")]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Required]
        [Column("Estado")]
        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [Required]
        [Column("CEP")]
        [Display(Name = "CEP")]
        public string CEP { get; set; }

        [Required]
        [Column("Pais")]
        [Display(Name = "País")]
        public string Pais { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Nome do Contato Principal")]
        public string NomeContatoPrincipal { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Cargo do Contato Principal")]
        public string CargoContatoPrincipal { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "E-mail do Contato")]
        public string EmailContato { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Telefone do Contato")]
        public string TelefoneContato { get; set; }

        [Column("ProdutoServicoAdquirido")]
        [Display(Name = "Produto/Serviço Adquirido")]
        public string ProdutoServicoAdquirido { get; set; }

        [Column("ValorCompra")]
        [Display(Name = "Valor da Compra")]
        public int ValorCompra { get; set; }

        [Column("ReceitaAnual")]
        [Display(Name = "Receita Anual")]
        public int ReceitaAnual { get; set; }

        [Column("Lucratividade")]
        [Display(Name = "Lucratividade")]
        public int Lucratividade { get; set; }
    }
}
