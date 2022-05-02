using System.ComponentModel.DataAnnotations;

namespace EDH2COD.Models
{
    public class DeckPreviewURL
    {
        [Required(ErrorMessage = "Please, submit a EDHRec Url.")]
        [RegularExpression(@"(https:\/\/)?(www.)?edhrec\.com\/deckpreview\/([a-zA-Z]+(\d[a-zA-Z]+)+)", ErrorMessage = "Please, make sure you are entering a valid URL address. It should be a URL to a deck list from edhrec.com and the url should contain 'edhrec.com/deckpreview/ on it.")]
        public string? Url;
    }
}
