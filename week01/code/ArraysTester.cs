public static class ArraysTester {
    /// <summary>
    /// Entry point for the tests
    /// </summary>
    public static void Run() {
        // Sample Test Cases (may not be comprehensive)
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        double[] multiples = MultiplesOf(7, 5);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{7, 14, 21, 28, 35}
        multiples = MultiplesOf(1.5, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{1.5, 3.0, 4.5, 6.0, 7.5, 9.0, 10.5, 12.0, 13.5, 15.0}
        multiples = MultiplesOf(-2, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{-2, -4, -6, -8, -10, -12, -14, -16, -18, -20}

        Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 1);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{9, 1, 2, 3, 4, 5, 6, 7, 8}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 5);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{5, 6, 7, 8, 9, 1, 2, 3, 4}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 3);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{7, 8, 9, 1, 2, 3, 4, 5, 6}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 9);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{1, 2, 3, 4, 5, 6, 7, 8, 9}
    }
    /// <summary>
    /// This function will produce a list of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    private static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // First create a static array that has the length of the length variable
        // Then populate the list using a loop by updating each value of 
        // the list with the next multiple of the given number
        var listOfMultiples = new double[length];
        for (int i = 1; i< length+1;i++){
            listOfMultiples[i-1] = number*i;
        }
        return listOfMultiples; // replace this return statement with your own
    }
    
    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// <c>&lt;List&gt;{1, 2, 3, 4, 5, 6, 7, 8, 9}</c> and an amount is 3 then the list returned should be 
    /// <c>&lt;List&gt;{7, 8, 9, 1, 2, 3, 4, 5, 6}</c>.  The value of amount will be in the range of <c>1</c> and 
    /// <c>data.Count</c>.
    /// <br /><br />
    /// Because a list is dynamic, this function will modify the existing <c>data</c> list rather than returning a new list.
    /// </summary>
    private static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Utilizing the built in functions in C# we can figure this out
        // First we figure out if the amount is larger than the length of the list.
        // calculate a new amount by calculating the amount % data.Count.
        // Now we can create two lists, call the first list last list
        // Using the GetRange function we want to populate this list with the values
        // we want at the end of our new list. So call the GetRange function from 0 with  
        // all of the values from the beginning until the amount we want to rotate by.
        // Now we want to remove those elements from our data list so call the RemoveRange
        // function with the same previous values.
        // Now create the second list and call it first list
        // Using the GetRange function starting at index 0, grab the rest of the 
        // data list, using a count value of data.Count
        // Now call the RemoveRange function with the values we most recently used in the GetRange
        // function.
        // The list data is now empty, and we have two lists. One list that has the numbers we
        // want last and the other with the numbers we want first, convenietly labeled last
        // and first. We now add these lists to our data list using the AddFirst function making
        // sure we add the last list after we add the first list.

        var moduloAmount = amount % data.Count;
        var lastList = new List<int>{};
        lastList = data.GetRange(0, data.Count - moduloAmount);
        data.RemoveRange(0,data.Count - moduloAmount);
        var firstList = new List<int>{};
        firstList = data.GetRange(0, data.Count);
        data.RemoveRange(0,data.Count);
        data.AddRange(firstList);
        data.AddRange(lastList);
    }
}
