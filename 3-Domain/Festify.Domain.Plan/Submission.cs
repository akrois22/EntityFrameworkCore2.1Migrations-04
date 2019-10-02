namespace Festify.Domain.Plan
{
    public class Submission
    {
        public int SubmissionId { get; private set; }

        public int TalkId { get; private set; }
        public Talk Talk { get; internal set; }

        public int ConferenceId { get; set; }
        public bool Accepted { get; set; }
    }
}
