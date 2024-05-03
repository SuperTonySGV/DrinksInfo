using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksInfo.Models
{
    public class Drink
    {
        public string IdDrink { get; set; }
        public string strDrink { get; set; }
    }

    public class Drinks
    {
        [JsonProperty("drinks")]

        public List<Drink> DrinksList { get; set; }
    }
}
