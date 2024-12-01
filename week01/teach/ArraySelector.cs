public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        var toReturn = new List<int>();
        int oneIndex = 0;
        int twoIndex = 0;
        foreach (int selector in select) {
            if (selector == 1) {
                toReturn.Add(list1[oneIndex]);
                oneIndex++;
            }
            else {
                toReturn.Add(list1[twoIndex]);
                twoIndex++;
            }
        }
        return toReturn.ToArray();
    }
}