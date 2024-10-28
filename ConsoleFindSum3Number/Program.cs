int[] numbersArray = Enumerable.Range(1, 50).ToArray();

CollectionHelper.FindCoupleSumOperands(10, numbersArray);
CollectionHelper.FindCoupleSumOperands(15, numbersArray);
CollectionHelper.FindCoupleSumOperands(20, numbersArray);

public static class CollectionHelper
{
    public static void FindCoupleSumOperands(int targetNumber, int[] numbersArray, bool isInner = false)
    {
        var operands = new HashSet<int>();

        foreach (var number in numbersArray)
        {
            var difference = targetNumber - number;

            if (operands.Contains(difference))
            {
                var innerOperands = new HashSet<int>();
                
                foreach (var innerNumber in numbersArray)
                {
                    var innerDifference = difference - innerNumber;
                    
                    if (innerOperands.Contains(innerDifference))
                    {
                        Console.WriteLine($"{number} + {innerNumber} + {innerDifference} = {targetNumber}");
                    }

                    innerOperands.Add(innerNumber);
                }
            }

            operands.Add(number);
        }
    }
}