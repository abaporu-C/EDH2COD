namespace EDH2COD.Models
{
    public class CodFile
    {        
        public string? DeckName { get; set; }

        public List<Card>? Main { get; set; }

        public List<Card>? Side { get; set; }
    }
}
