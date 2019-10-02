namespace Festify.Domain.Explore
{
    public class Speaker
    {
        public int SpeakerId { get; private set; }

        public int ConferenceId { get; private set; }
        public Conference Conference { get; private set; }
    }
}
