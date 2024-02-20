using System.ComponentModel.DataAnnotations;

namespace SMSGateWay.Models
{
    public class TextMessage
    {
        [Required]
        [Phone]
        public string FromNumber { get; set; }

        [Required]
        [Phone]
        public string ToNumber { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(140)]
        public string Content { get; set; }
    }
}
