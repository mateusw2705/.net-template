using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryControl.Domain.Entities
{
    [Table("Pedido")]
    public class PedidoDeVenda
    {
        [Key]
        public int PedidoVendaId { get; set; }

        [StringLength(100, ErrorMessage = "O tamanho maximo é 100 caracteres")]
        [Required(ErrorMessage = "Informe a data do pedido")]
        [Display(Name = "Data")]
        public DateTime DataPedido { get; set; }

        [StringLength(100, ErrorMessage = "O tamanho maximo é 100 caracteres")]
        [Display(Name = "Data")]
        public DateTime DataPronidaoPedido { get; set; }

        
        [StringLength(100, ErrorMessage = "O tamanho maximo é 100 caracteres")]
        [Required(ErrorMessage = "Informe o cliente")]
        [Display(Name = "Cliente")]
        public int ClienteId { get; set; }

        [StringLength(100, ErrorMessage = "O tamanho maximo é 100 caracteres")]
        [Required(ErrorMessage = "Informe o Servico")]
        [Display(Name = "Serviço")]
        public int ServicoId { get; set; }

        public Clientes Cliente { get; set; }
        public ICollection<Servicos> Servicos { get; set; }


    }
}
