using System.ComponentModel.DataAnnotations;

namespace Word_no_Navegador.Models
{
    public class DocumentoModel
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage ="Titulo não preenchido")]
        public string Titulo { get; set; } = string.Empty;
        [Required(ErrorMessage = "Conteudo não preenchido")]
        public string Conteudo { get; set; } = string.Empty ;
        public DateTime dataCriacao { get; set; } = DateTime.Now;
        public DateTime DataAtualizacao { get; set; } = DateTime.Now;
    }
}
