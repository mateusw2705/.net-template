using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryControl.Domain.Entities
{
    [Table("Clientes")]
    public class Clientes
    {
       [Key]
       public int ClientesId { get; set; }
       [StringLength(100,ErrorMessage ="O tamanho maximo é 100 caracteres")]
       [Required(ErrorMessage ="Informe a Razão do cliente")]
       [Display(Name ="Razão")]
       public string Razao { get; set; }

       [StringLength(100, ErrorMessage = "O tamanho maximo é 100 caracteres")]
       [Required(ErrorMessage = "Informe o Cpf ou Cnpj")]
       [Display(Name = "CPF/CNPJ")]
       public string Cnpj_Cpf { get; set; }

       [StringLength(300, ErrorMessage = "O tamanho maximo é 300 caracteres")]
       [Required(ErrorMessage = "Informe o Endereço")]
       [Display(Name = "Endereço")]
       public string Endereço { get; set; }

       [StringLength(100, ErrorMessage = "O tamanho maximo é 100 caracteres")]
       [Required(ErrorMessage = "Informe o Email")]
       [Display(Name = "Email")]
       public string Email { get; set; }

        /// <summary>
        // Relacionamento um-para-muitos com Agedamentos
        /// </summary>
        public ICollection<Agendamento> Agendamentos { get; set; }
        /// <summary>
        // Relacionamento um-para-muitos com Pedidos de Venda
        /// </summary>
        public ICollection<PedidoDeVenda> PedidosVenda { get; set; }
    }
}
