using System.ComponentModel.DataAnnotations;

namespace WebNotas.Models
{
    public class NF
    {
        [Key]
        public Guid NotaFiscalId { get; set; }

        public int NumeroNf { get; set; }

        public decimal ValorTotal { get; set; }

        public DateTime DataNf { get; set; }

        public string CnpjEmissorNf { get; set; }

        
        public string CnpjDestinatarioNf { get; set; }
    }
}
