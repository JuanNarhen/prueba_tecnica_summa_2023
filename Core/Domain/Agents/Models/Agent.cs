using Core.Domain.Agents.Contracts;

namespace Core.Domain.Agents.Models
{
    public abstract class Agent : IAgentStrategy
    {
        public abstract double GetMedia(List<double> numbers);

        public abstract string GetStaircase(int size);

        protected void ValidateSize(int size)
        {
            if (!IsValidSize(size))
                throw new ArgumentException("Size must be higher than zero and less than one hundred.");
        }

        private bool IsValidSize(int size)
        {
            if (0 <= size && size <= 100)
                return true;
            else
                return false;
        }
    }
}
