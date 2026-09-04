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
        //In this case I think we can use double[] because the return type is double[] and we are returning an array of doubles. I make it public so it can be accessed from other classes.Also, I make it static so it can be called without creating an instance of the class; I use the parameters double number and int length to specify the number to multiply and the length of the array to create. I will create a new array of doubles with the specified length, then use a for loop to fill the array with multiples of the number. Finally, I will return the array.//

        double[] result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        return result;
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
        //For this function, I will use data.GetRange to separate the original list into two parts: the last 'amount' elements (partA)and the rest of the list(partB) I will then clear the original list with data.RemoveRange, and add the two parts back in reverse order to achieve the rotation effect.//

        List<int> partA = data.GetRange(data.Count - amount, amount);
        List<int> partB = data.GetRange(0, data.Count - amount);

        data.RemoveRange(0, data.Count);

        data.AddRange(partA);
        data.AddRange(partB);
    }
}
