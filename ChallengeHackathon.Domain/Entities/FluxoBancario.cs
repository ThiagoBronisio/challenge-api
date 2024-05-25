using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeHackathon.Domain.Entities
{
    public class FluxoBancario
    {
        public string? Valor  { get; set; }
        public string? Historico { get; set; }
        public float?  SaldoAnterior { get; set; }
        public int? Entrada { get; set; }

    }
}
