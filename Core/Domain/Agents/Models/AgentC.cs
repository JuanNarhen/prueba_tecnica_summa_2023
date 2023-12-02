namespace Core.Domain.Agents.Models
{
    public class AgentC : Agent
    {
        public override double GetMedia(List<double> numbers)
        {
            var orderedNumbers = numbers.OrderBy(x => x).ToList();
            var isPairLengthCollection = numbers.Count % 2 == 0;
            var halfIndex = (numbers.Count / 2) - 1;

            var median = isPairLengthCollection ?
                (orderedNumbers[halfIndex] + orderedNumbers[halfIndex + 1]) / 2 :
                orderedNumbers[halfIndex + 1];

            return median;
        }

        public override string GetStaircase(int size)
        {
            ValidateSize(size);

            var baseStairsFloorsList = new List<string>();
            var totalIterations = size - 1;

            //Print first lines (before middle line)
            for(int i = 0; i < totalIterations; i++)
            {
                var pounds = new String('#', size + (2 * i));
                var whiteSpaces = new String(' ', totalIterations - i);
                baseStairsFloorsList.Add($"{whiteSpaces}{pounds}{whiteSpaces}");
            }

            //Claculate middleline, having in count that by each iteration required 2 pounds
            //should be added
            var middleLine = new String('#', size + (2 * totalIterations));

            var stairs = String.Join("\n", baseStairsFloorsList);
            stairs += $"\n{middleLine}\n";

            //Reverse initial collection for get inverse print pattern
            baseStairsFloorsList.Reverse();
            stairs += String.Join("\n", baseStairsFloorsList);

            return stairs;
        }
    }
}
