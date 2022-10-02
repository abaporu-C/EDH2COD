using System.ComponentModel.DataAnnotations;

namespace EDH2COD.Models{
    public class QueryModel{
        [Required]
        [RegularExpression(@"^https://edhrec.com/(deckpreview|avarage-decks)/*", ErrorMessage="Please, insert a valid EDHREC URl. It should start with \"https://edhrec.com\"")]
        public string? Name {get; set;}
    }
}
