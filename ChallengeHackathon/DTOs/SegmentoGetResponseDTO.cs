namespace ChallengeHackathon.DTOs
{
    public class SegmentoGetResponseDTO
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
