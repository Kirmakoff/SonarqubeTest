using System;
using System.Collections.Generic;

namespace SonarqubeTest.Challenges;

public static class HelperMethods
{
    public static List<int> GetIntsList(int count, int min = 1, int max = 100)
    {
        var random = new Random();
        var myList = new List<int>();
        for (int i = 0; i < count; i++)
        {
            myList.Add(random.Next(min, max));
        }
        return myList;
    }
}