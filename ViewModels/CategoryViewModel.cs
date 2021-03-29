using Newtonsoft.Json;

namespace ShoppingCart.ViewModels
{
    /**
     * Au fost scoase anumite campuri din Category model pentru a nu include si lista de carti
     * intrucat view-ul ce utilizeaza acest model nu are nevoie sa afiseze cartile
     */
    public class CategoryViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}