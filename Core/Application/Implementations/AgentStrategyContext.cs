using Core.Application.Contracts;
using Core.Domain.Agents.Constants;
using Core.Domain.Agents.Contracts;
using Core.Domain.Agents.Models;

namespace Core.Application.Implementations
{
    public class AgentStrategyContext : IMathMedia, IStairsRepresentation
    {
        private IAgentStrategy _agent;

        public void SetStrategy(AgentType agentType)
        {
            switch(agentType)
            {
                case AgentType.AgentA:
                    _agent = new AgentA();
                    break;

                case AgentType.AgentB:
                    _agent = new AgentB();
                    break;

                case AgentType.AgentC:
                    _agent = new AgentC();
                    break;
            }
        }

        public double GetMedia(List<double> numbers)
        {
            if(_agent != null)
            {
                return _agent.GetMedia(numbers);
            }

            throw new NullReferenceException("Agent is null. First call 'SetStrategy' method for define the agent.");
        }

        public string GetStaircase(int size)
        {
            if(_agent != null)
            {
                return _agent.GetStaircase(size);
            }

            throw new NullReferenceException("Agent is null. First call 'SetStrategy' method for define the agent.");
        }
    }
}
