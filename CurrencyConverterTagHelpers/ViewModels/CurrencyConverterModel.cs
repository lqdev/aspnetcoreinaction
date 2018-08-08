using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CurrencyConverterTagHelpers.ViewModels
{
    public class CurrencyConverterModel
    {
        [Required]
        [MaxLength(3)]
        [Display(Name = "Currency From")]
        public string CurrencyFrom { get; set; }
        [Required]
        [MaxLength(3)]
        [Display(Name = "Currency To")]
        public string CurrencyTo { get; set; }
        [Required]
        [Display(Name = "Quantity")]
        public double Quantity { get; set; }
    }
}