using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryControl.Domain.Entities
{
    [Table("Servico")]
   public class Servicos
    {
        [Key]
        public int ServicoId { get; set; }

        [StringLength(100, ErrorMessage = "O tamanho maximo é 100 caracteres")]
        [Required(ErrorMessage = "Informe o nome do serviço")]
        [Display(Name = "Servico")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o preço orretamente")]
        [Display(Name = "Data")]
        [Column(TypeName ="decimal(10,2)")]
        public decimal Preco { get; set; }
        // Outros campos relacionados ao serviço, se necessário

        // Relacionamento um-para-muitos com Pedidos de Venda
        public ICollection<PedidoDeVenda> PedidosVenda { get; set; }
    }
}
