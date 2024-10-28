int[] numbersArray = Enumerable.Range(1, 50).ToArray();

CollectionHelper.FindTripleSumOperands(10, numbersArray);
CollectionHelper.FindTripleSumOperands(15, numbersArray);
CollectionHelper.FindTripleSumOperands(20, numbersArray);

public static class CollectionHelper
{
    public static void FindTripleSumOperands(int targetNumber, int[] numbersArray, bool isInner = false)
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