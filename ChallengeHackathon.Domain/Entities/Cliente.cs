using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeHackathon.Domain.Entities
{
    public class Cliente
    {
        public DateTime? DataCadastro { get; set; }
        public int? FormaPagamento { get; set; }
    }
}
