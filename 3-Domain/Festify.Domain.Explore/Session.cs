//using System.ComponentModel.DataAnnotations;
//using Festify.Domain.Plan;

using System.ComponentModel.DataAnnotations;

namespace Festify.Domain.Explore
{
    public class Session
    {
        public int SessionId { get; private set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        public string Abstract { get; set; }
    }
}