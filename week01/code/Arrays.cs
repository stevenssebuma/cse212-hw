public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {

        // Step 1: Create an array to hold the multiples.  
        double[] multiples = new double[length];  

    // Step 2: Use a loop to fill the array with multiples of the given number.  
        for (int i = 0; i < length; i++)  
        {  
        // Calculate the (i + 1)-th multiple of the number and store it in the array.  
            multiples[i] = number * (i + 1);  
        }  

        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
            // Step 1: Calculate effective rotation amount.  
        int count = data.Count;  
        amount = amount % count; // Normalize the amount in case it's larger than count.  

        // Step 2: Define the split index.  
        int splitIndex = count - amount;

    // If the amount is 0, no rotation is needed.  
        if (amount == 0)

        return;  

    // Step 3: Create the two segments.  
        List<int> endSegment = data.GetRange(splitIndex, amount); // Segment to move to front  
        List<int> startSegment = data.GetRange(0, splitIndex); // Remaining segment  

    // Step 4: Clear the original list and add the new order.  
        data.Clear(); // Clear the original list  
        data.AddRange(endSegment); // Add end segment first  
        data.AddRange(startSegment);
        
    }
}
