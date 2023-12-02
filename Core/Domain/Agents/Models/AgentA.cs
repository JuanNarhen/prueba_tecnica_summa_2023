namespace Core.Domain.Agents.Models
{
    public class AgentA : Agent
    {
        public override double GetMedia(List<double> numbers)
        {
            return numbers.Sum() / numbers.Count;
        }

        public override string GetStaircase(int size)
        {
            ValidateSize(size);

            var stairs = "";

            for(int i = 1; i <= size; i++)
            {
                var pounds = new String('#', i);
                var spaces = new String(' ', size - i);
                stairs += $"{spaces}{pounds}\n";
            }

            return stairs;
        }
    }
}
