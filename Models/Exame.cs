using SirespFacil.Models;


public class Exame
    {
    public int Id { get; set; }
    public TipoExame Tipo { get; set; }
    public List<string> CaminhosArquivos { get; set; } = new List<string>();
    public DateTime Data { get; set; }
}
