namespace ChallengeHackathon.DTOs
{
    public class DespesaGetResponseDTO
    {
        public float? Movimentacao { get; set; }
        public string? Transacao { get; set; }
        public DateTime? DataHora { get; set; }
        public float? SaldoAnterior { get; set; }
        public int? Entrada { get; set; }
        public float? Novo_Saldo { get; set; }
        public float? Movimentacao_Geral { get; set; }
        public int? Contagem_Movimentacao { get; set; }
        public int? ClienteId { get; set; }
        public string? Segmento { get; set; }
    }
}
