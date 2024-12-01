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
        // Instantiate new array to hold values to return
        var multiplesOf = new double[length];

        // Use index values to simultaneuosly set and get multiples
        for (int i = 0; i < length; i++) {
            multiplesOf[i] = number * (i + 1);
        }

        // Return array
        return multiplesOf;
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
        // Copy slice from indexes "list size - amount" till the end
        var thisSlice = data.GetRange(data.Count - amount, amount);

        // Deletes copied data from original
        data.RemoveRange(data.Count - amount, amount);

        // Inserts copied slice to the beginning of "data"
        data.InsertRange(0, thisSlice);
    }
}
