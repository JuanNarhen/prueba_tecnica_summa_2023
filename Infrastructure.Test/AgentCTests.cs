using Core.Application.Implementations;
using Core.Domain.Agents.Constants;

namespace Infrastructure.Test
{
    public class AgentCTests
    {
        [Test]
        public void Ok_AgentC_PairLengthNumbersList_GetMedia()
        {
            var expectedMedia = 9.5d;
            var numbersList = new List<double>() { 10d, 18d, 15d, 17d, 9d, 8d, 2d, 5d };
            var agentsContext = new AgentStrategyContext();
            agentsContext.SetStrategy(AgentType.AgentC);
            
            var result = agentsContext.GetMedia(numbersList);

            Assert.AreEqual(expectedMedia, result);
        }

        [Test]
        public void Ok_AgentC_OddLengthNumbersList_GetMedia()
        {
            var expectedMedia = 9d;
            var numbersList = new List<double>() { 10d, 18d, 15d, 17d, 9d, 8d, 2d, 5d, 1d };
            var agentsContext = new AgentStrategyContext();
            agentsContext.SetStrategy(AgentType.AgentC);

            var result = agentsContext.GetMedia(numbersList);

            Assert.AreEqual(expectedMedia, result);
        }

        [Test]
        public void Ok_AgentC_GetStaircase()
        {
            var size = 4;
            var expectedResult = "   ####   \n  ######  \n ######## \n##########\n ######## \n  ######  \n   ####   ";
            var agentsContext = new AgentStrategyContext();
            agentsContext.SetStrategy(AgentType.AgentC);

            var result = agentsContext.GetStaircase(size);

            Assert.IsTrue(result.Equals(expectedResult));
        }
    }
}