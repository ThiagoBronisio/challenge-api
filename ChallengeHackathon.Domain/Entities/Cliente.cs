﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeHackathon.Domain.Entities
{
    public class Cliente
    {
        public float? Movimentacao { get; set; }
        public string? Transacao { get; set; }
        public DateTime? DataHora { get; set; }
        public int? Entrada { get; set; }
        public int? Contagem_Movimentacao { get; set; }
        public int? ClienteId { get; set; }
        public string? Segmento { get; set; }
    }
}
