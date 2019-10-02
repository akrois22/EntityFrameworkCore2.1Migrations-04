using Festify.Domain.Explore;
using Festify.Domain.Plan;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Domain.Plan
{
    public class Talks
    {
        [Fact]
        public void Create()
        {
            var presenter = GivenPresenter();
            var talk = GivenTalk();
            var conferenceId = GivenConference();
            var submission = WhenSubmitTalk(talk, conferenceId);
            submission.Talk.Should().Be(talk);
            submission.ConferenceId.Should().Be(conferenceId);
            talk.Submissions.Count().Should().Be(1);
        }

        private static Presenter GivenPresenter()
        {
            return new Presenter();
        }
        private static Talk GivenTalk()
        {
            return new Talk();
        }
        private int GivenConference()
        {
            return new Conference().ConferenceId;
        }
        private Submission WhenSubmitTalk(Talk talk, int conferenceId)
        {
            return talk.Submit(conferenceId);
        }
    }
}
