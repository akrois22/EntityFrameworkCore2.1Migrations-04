using System;
namespace Festify.Domain.Plan
{
    public class Submission
    {
        public int SubmissionId { get; private set; }

        public int TalkId { get; private set; }
        public Talk Talk { get; internal set; }

        public int ConferenceId { get; internal set; }
        public bool Accepted { get; private set; }
        public DateTime DateSubmitted { get; internal set; }
        public DateTime? DateAccepted { get; private set; }
        public void Accept()
        {
            Accepted = true;
            DateAccepted = DateTime.UtcNow;
        }
    }
}
