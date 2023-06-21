using System.ComponentModel.DataAnnotations;

namespace MVC_projeto_gamer.Models
{
    public class Equipe
    {
        [Key]//Data Annotation - IdEquipe
        public int IdEquipe { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }

        //Referencia que a classe equipe vai ter acesso a colletion "Jogador"
        public ICollection<Jogador> Jogador { get; set; }

    }
}