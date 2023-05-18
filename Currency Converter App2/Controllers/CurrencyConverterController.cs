using Currency_Converter_App2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Currency_Converter_App2.Controllers
{
   
    public class CurrencyConverter : Controller
    {
        public Dictionary<string,decimal> Currency { get; set; }
        public CurrencyConverter()
        {
            Currency = new Dictionary<string, decimal>();
            Currency.Add("USD", 1.0m);
            Currency.Add("EUR", .908239m);
            Currency.Add("JPY", 136.528m);
          
        }

        public IActionResult Index()
        {
            CurrencyConverterViewModel viewModel = new CurrencyConverterViewModel();
            return View(viewModel);
        }


        public IActionResult Convert(CurrencyConverterViewModel viewModel)
        {
            decimal convertedAmount = 0.0m;
            decimal rateFrom = 0.0m;
            decimal rateTo = 0.0m;
            
            if (viewModel.FromCurrency == viewModel.ToCurrency)
            {
                convertedAmount = viewModel.ConvertedAmount;
                
            }
            if(viewModel.FromCurrency == "USD")
            {
                 rateFrom= Currency[viewModel.FromCurrency];
                 rateTo = Currency[viewModel.ToCurrency];
                convertedAmount = viewModel.Amount * (rateTo / rateFrom);
            }
           else if(viewModel.FromCurrency == "EUR")
            {
                rateFrom = Currency[viewModel.FromCurrency];
                rateTo = Currency[viewModel.ToCurrency];
                convertedAmount = viewModel.Amount * (rateTo / rateFrom);

            }
            else if(viewModel.FromCurrency=="JPY")
            {
                rateFrom = Currency[viewModel.FromCurrency];
                rateTo = Currency[viewModel.ToCurrency];
                convertedAmount = viewModel.Amount * (rateTo / rateFrom);
            }
            viewModel.ConvertedAmount = convertedAmount;
            return View("Index",viewModel);
        }
    }

}