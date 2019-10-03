using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Festify.Domain.Plan
{
    public class Presenter
    {
        private List<Talk> _talks = new List<Talk>();

        public int PresenterId { get; private set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public string Bio { get; set; }

        public IEnumerable<Talk> Talks => _talks;

        public Talk NewTalk()
        {
            var talk = new Talk();
            _talks.Add(talk);
            return talk;
        }
    }
}
