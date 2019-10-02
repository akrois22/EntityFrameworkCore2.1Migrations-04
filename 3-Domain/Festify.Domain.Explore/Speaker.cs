using System.Collections.Generic;

namespace Festify.Domain.Explore
{
    public class Speaker
    {
        private List<Session> _sessions = new List<Session>();

        public int SpeakerId { get; private set; }

        public int ConferenceId { get; private set; }
        public Conference Conference { get; private set; }

        public IEnumerable<Session> Sessions => _sessions;
    }
}
