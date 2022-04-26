using Domain.Enum;
using System.ComponentModel.DataAnnotations;

namespace Persistence.ViewModel
{
    public class OperationViewModel
    {
        [Display(Name = "First Number")]
        [Required]
        public double Num1 { get; set; }

        [Display(Name = "Second Number")]
        [Required]
        public double Num2 { get; set; }

        [Display(Name = "Result")]
        public double Result { get; set; }

        [Display(Name = "Operation")]
        public OperationType OperationType { get; set; } = OperationType.Addition;

    }
}
