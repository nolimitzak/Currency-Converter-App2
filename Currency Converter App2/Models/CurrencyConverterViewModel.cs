using System.ComponentModel.DataAnnotations;

namespace Currency_Converter_App2.Models
{
    public class CurrencyConverterViewModel
    {
        public decimal Amount { get; set; }
        public string? FromCurrency { get; set; }
        public string? ToCurrency { get; set; }
        public List<string> CurrencyList { get; set; }
        public decimal ConvertedAmount { get; set; }
        public CurrencyConverterViewModel()
        {
            CurrencyList = new List<string>
           {
               "USD",
               "EUR",
               "JPY"
           };
        }
    }
}
