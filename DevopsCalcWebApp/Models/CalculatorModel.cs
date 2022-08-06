using System.ComponentModel.DataAnnotations;

namespace DevopsCalcWebApp.Models
{
    public class CalculatorModel
    {
        [Display(Name ="Valor 1 :")]
        public double Value1 { get; set; }
        [Display(Name="Valor 2 :")]
        public double Value2 { get; set; }
        [Display(Name ="Total :")]
        public double Total { get; set; }

    }
}
