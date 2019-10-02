using System.Collections.Generic;

namespace Festify.Domain.Plan
{
    public class Presenter
    {
        private List<Talk> _talks = new List<Talk>();

        public int PresenterId { get; private set; }

        public IEnumerable<Talk> Talks => _talks;

        public Talk NewTalk()
        {
            var talk = new Talk();
            _talks.Add(talk);
            return talk;
        }
    }
}
