namespace SirespFacil.Models.ViewModels
{
    public class ExameViewModel
    {

        public int Id { get; set; }
        public TipoExame Tipo { get; set; }
        public List<IFormFile> Arquivos { get; set; } = new List<IFormFile>();
        public DateTime Data { get; set; }

    }
}
