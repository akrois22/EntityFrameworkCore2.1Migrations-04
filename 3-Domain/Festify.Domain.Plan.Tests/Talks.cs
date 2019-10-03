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
            var conference = GivenConference();
            var submission = WhenSubmitTalk(talk, conference);
            submission.Talk.Should().Be(talk);
            submission.ConferenceId.Should().Be(conference.ConferenceId);
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
        private static Conference GivenConference()
        {
            return new Conference();
        }
        private Submission WhenSubmitTalk(Talk talk, Conference conference)
        {
            return talk.Submit(conference.ConferenceId);
        }
    }
}
