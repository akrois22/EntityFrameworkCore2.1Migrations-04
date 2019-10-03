using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Festify.Domain.Plan
{
    public class Talk
    {
        private List<Submission> _submissions = new List<Submission>();
        public int TalkId { get; private set; }

        public int PresenterId { get; private set; }
        public Presenter Presenter { get; private set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        public string Abstract { get; set; }
        public IEnumerable<Submission> Submissions => _submissions;

        public Submission Submit(int conferenceId)
        {
            var submission = new Submission
            {
                Talk = this,
                ConferenceId = conferenceId,
                DateSubmitted = DateTime.UtcNow
            };
            _submissions.Add(submission);
            return submission;
        }
    }
}