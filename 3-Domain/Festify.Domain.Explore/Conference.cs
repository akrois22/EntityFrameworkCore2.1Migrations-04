using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Festify.Domain.Explore
{
    public class Conference
    {
        private List<Speaker> _speakers = new List<Speaker>();
        
        public IEnumerable<Speaker> Speakers => _speakers;

        public int ConferenceId { get; private set; }
        [Required]
        [MaxLength(50)]
        public string Identity { get; set; }

        public void AddSpeaker()
        {
            _speakers.Add(new Speaker());
        }
    }
}
