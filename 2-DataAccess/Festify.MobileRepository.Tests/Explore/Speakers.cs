using Festify.Domain.Explore;
using Festify.MobileRepository.Explore;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xunit;

namespace MobileRepository.Explore
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

        private ExploreContext GivenExploreContext(
            [CallerMemberName] string method = "",
            [CallerFilePath] string file = "")
        {
            return new ExploreContext(new DbContextOptionsBuilder()
                .UseInMemoryDatabase($"{file}.{method}")
                .Options);
        }

        private async Task GivenOneConference(ExploreContext context)
        {
            var conference = new Conference();
            conference.Identity = "awesomecon";
            await context.Conference.AddAsync(conference);
            await context.SaveChangesAsync();
        }

        private async Task<Conference> WhenLoadConference(ExploreContext context)
        {
            return await context.Conference
                .Where(c => c.Identity == "awesomecon")
                .SingleAsync();
        }
    }
}
