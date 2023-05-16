using System.Text.Json.Serialization;

namespace ProiectCofetarie
{
	public class Produs
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }
		[JsonPropertyName ("denumireProd")]
        public string DenumireProd { get; set; }
        [JsonPropertyName("pret")]
        public int Pret { get; set; }
		[JsonPropertyName("cantitate")]
		public int Cantitate {get; set; }
	
	}
}
