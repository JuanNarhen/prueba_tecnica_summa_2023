using Core.Application;
using Core.Domain.Agents.Constants;

namespace Infrastructure.Test
{
    public class AgentBTests
    {
        [Test]
        public void Ok_AgentB_GetMedia()
        {
            var expectedMedia = 6.5726943213854216d;
            var numbersList = new List<double>() { 10d, 18d, 15d, 17d, 9d, 8d, 2d, 5d };
            var agentsContext = new AgentStrategyContext();
            agentsContext.SetStrategy(AgentType.AgentB);
            
            var result = agentsContext.GetMedia(numbersList);

            Assert.AreEqual(expectedMedia, result);
        }

        [Test]
        public void Ok_AgentB_GetStaircase()
        {
            var size = 4;
            var expectedResult = "####\n ###\n  ##\n   #\n";
            var agentsContext = new AgentStrategyContext();
            agentsContext.SetStrategy(AgentType.AgentB);

            var result = agentsContext.GetStaircase(size);

            Assert.IsTrue(result.Equals(expectedResult));
        }
    }
}