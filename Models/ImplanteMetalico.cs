namespace SirespFacil.Models
{
    public class ImplanteMetalico
    {
        public int Id { get; set; }
        public string Dispositivo { get; set; }
        public TimeSpan TempoDeUso { get; set; }
        public string Material { get; set; }
        public string Localizacao { get; set; }
        public RessonanciaMagnetica RessonanciaMagnetica { get; set; }
    }
}
