namespace SirespFacil.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string? Nome { get; set; } = "";
        public string? CodigoSIRESP { get; set; }
        public DateOnly DataNascimento { get; set; }
        public char? Sexo { get; set; }

        public int Idade { get; set; } = 0;
        public List<RessonanciaMagnetica> RessonanciaMagneticas { get; set; } = new();
    }
}
