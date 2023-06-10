namespace RpgMvc.Models
{
    public class ArmaViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Dano { get; set; }
        public PersonagemViewModel Personagem { get; set; }
        public int PersonagemId { get; set; }
    }
}