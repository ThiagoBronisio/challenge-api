using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeHackathon.Domain.Entities
{
    public class FluxoBancario
    {
        public float? Movimentacao { get; set; }
        public string? Transacao { get; set; }
        public DateTime? DataHora { get; set; }
        public float? SaldoAnterior { get; set; }
        public int? Entrada { get; set; }
        public float? Novo_Saldo {  get; set; }
        public float? Movimentacao_Geral { get; set; }
        public int? Contagem_Movimentacao { get; set; }
    }
}
