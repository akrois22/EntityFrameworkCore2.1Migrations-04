using Festify.Domain.Explore;
using FluentAssertions;
using System.Linq;
using Xunit;

namespace Festify.Domain.Explore.Tests
{
    public class Speakers
    {
        [Fact]
        public void None()
        {
            var conference = GivenConference();
            conference.Speakers.Count().Should().Be(0);
        }

        [Fact]
        public void Add()
        {
            var conference = GivenConference();
            WhenAddSpeaker(conference);
            conference.Speakers.Count().Should().Be(1);
        }

        private Conference GivenConference()
        {
            return new Conference();
        }

        private void WhenAddSpeaker(Conference conference)
        {
            conference.AddSpeaker();
        }
    }
}
