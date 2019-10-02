using Festify.Domain.Explore;
using Festify.MobileRepository.Explore;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xunit;

namespace MobileRepository.Explore
{
    public class Conferences
    {
        [Fact]
        public async Task Identifier_is_unique()
        {
            var context = GivenExploreContext();

            await WhenAddConference(context);
            Func<Task> action = async () => await WhenAddConference(context);

            action.Should().Throw<InvalidOperationException>();
        }

        private ExploreContext GivenExploreContext(
            [CallerMemberName] string method = "",
            [CallerFilePath] string file = "")
        {
            return new ExploreContext(new DbContextOptionsBuilder()
                .UseInMemoryDatabase($"{file}.{method}")
                .Options);
        }

        private async Task WhenAddConference(ExploreContext context)
        {
            var conference = new Conference();
            conference.Identity = "awesomecon";
            await context.Conference.AddAsync(conference);
            await context.SaveChangesAsync();
        }
    }
}
