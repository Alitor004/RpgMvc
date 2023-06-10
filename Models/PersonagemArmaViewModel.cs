namespace RpgMvc.Models
{
    public class PersonagemArmaViewModel
    {
        public int PersonagemId { get; set; }
        public PersonagemViewModel Personagem { get; set; }
        public int ArmaId { get; set; }
        public ArmaViewModel Arma { get; set; }
    }
}