using System;

public class Program
{
    static void Main(string[] args)
    {
        List<int> newList = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        Console.WriteLine($"{newList.Count}\n");
        
        var thisList = newList.GetRange(newList.Count - 4, 4);

        foreach (int num in thisList) {
            Console.Write(num);
        }
    }
}