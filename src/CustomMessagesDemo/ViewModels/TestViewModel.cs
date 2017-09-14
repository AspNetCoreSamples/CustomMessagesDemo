using System.ComponentModel.DataAnnotations;

namespace CustomMessagesDemo.ViewModels
{
    public class TestViewModel
    {
        [Range(1, 10)]
        public decimal ADecimal { get; set; }
    }
}
