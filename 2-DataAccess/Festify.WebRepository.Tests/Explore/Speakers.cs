using Festify.Domain.Explore;
using Festify.WebRepository.Explore;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xunit;

namespace WebRepository.Explore
{
    public class Speakers
    {
        [Fact]
        public async Task None()
        {
            var context = GivenExploreContext();
            await GivenOneConference(context);

            var conference = await WhenLoadConference(context);
            conference.Speakers.Count().Should().Be(0);
        }

        [Fact]
        public async Task Add()
        {
            var context = GivenExploreContext();
            var c = await GivenOneConference(context);
            await GivenOneSpeaker(context, c);

            var conference = await WhenLoadConference(context);
            conference.Speakers.Count().Should().Be(1);
        }

        private ExploreContext GivenExploreContext(
            [CallerMemberName] string method = "",
            [CallerFilePath] string file = "")
        {
            return new ExploreContext(new DbContextOptionsBuilder<ExploreContext>()
                .UseInMemoryDatabase($"{file}.{method}")
                .Options);
        }

        private async Task<Conference> GivenOneConference(ExploreContext context)
        {
            var conference = new Conference();
            conference.Identity = "awesomecon";
            var entry = await context.Conference.AddAsync(conference);
            await context.SaveChangesAsync();
            return entry.Entity;
        }

        private async Task<Conference> WhenLoadConference(ExploreContext context)
        {
            return await context.Conference
                .Where(c => c.Identity == "awesomecon")
                .SingleAsync();
        }

        private async Task GivenOneSpeaker(ExploreContext context, Conference conference)
        {
            conference.AddSpeaker();
            await context.SaveChangesAsync();
        }
    }
}
