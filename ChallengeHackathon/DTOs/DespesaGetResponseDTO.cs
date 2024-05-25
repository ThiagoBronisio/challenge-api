namespace ChallengeHackathon.DTOs
{
    public class DespesaGetResponseDTO
    {
        public string? ClienteID { get; set; }
        public string? ReceitaID { get; set; }
        public float? Valor { get; set; }
        public float? TotalGasto { get; set; }
    }
}
