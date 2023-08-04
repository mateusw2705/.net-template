using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryControl.Domain.Entities
{
    [Table("Agendamento")]
    public class Agendamento
    {
        [Key]
        public int AgendamentoId { get; set; }

        [StringLength(100, ErrorMessage = "O tamanho maximo é 100 caracteres")]
        [Required(ErrorMessage = "Informe a data e horario do agendamento")]
        [Display(Name = "Data")]
        public DateTime DataHora { get; set; }
        public int ClienteId { get; set; }
        public Clientes Cliente { get; set; }
        public int ServicoId { get; set; }
        public ICollection <Servicos> Servico  { get; set; }
    }
}
