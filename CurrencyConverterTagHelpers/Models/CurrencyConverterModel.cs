using System.ComponentModel.DataAnnotations;

namespace CurrencyConverterTagHelpers.Models
{
    public class CurrencyConverterModel
    {
        [Required]
        [StringLength(3,MinimumLength=3)]
        [Display(Name="Currency From")]
        public string CurrencyFrom { get; set; }
        
        [Required]
        [StringLength(3,MinimumLength=3)]
        [Display(Name="Currency To")]
        public string CurrencyTo { get; set; }
        
        [Required]
        [Range(0,10000)]
        public float Quantity { get; set; }
    }
}