namespace Core.Domain.Agents.Models
{
    public class AgentB : Agent
    {
        public override double GetMedia(List<double> numbers)
        {
            return numbers.Count / numbers.Sum(x => 1 / x);
        }

        public override string GetStaircase(int size)
        {
            ValidateSize(size);

            var stairs = "";

            for (int i = size; i >= 1; i--)
            {
                var pounds = new String('#', i);
                var spaces = new String(' ', size - i);
                stairs += $"{spaces}{pounds}\n";
            }

            return stairs;
        }
    }
}
