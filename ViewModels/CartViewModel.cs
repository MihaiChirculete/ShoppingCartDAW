using Newtonsoft.Json;
using System.Collections.Generic;

namespace ShoppingCart.ViewModels
{
    /**
     * Nu am inclus si SessionId deoarece acesta este identificatorul unic al serverului
     * si nu trebuie expus publicului
     */
    public class CartViewModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "cartItems")]
        public virtual ICollection<CartItemViewModel> CartItems { get; set; }
    }
}