using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SonarqubeTest.Challenges;

public class EasyToMissExceptions
{
    public static bool SomeReallyWeirdEdgeCase = false; 
    public static bool SomeCondition = true;
	
    public async Task<ProcessedData> AnalyzeData(List<SensorData> rawSensorData)
    {
        var processed = new ProcessedData();
		
        foreach (var sensorData in rawSensorData)
        {
            if(SomeReallyWeirdEdgeCase)
            {
                rawSensorData.Remove(sensorData);
                continue;
            }
			
            if(SomeCondition)
            {
                //processed.Add
                await Task.Delay(5);
            }
			
            else
            {
                //...
            }
			
            await Task.Delay(5);		
        }
		
        return processed;
    }
    
    public static int HelloBadIndex()
    {
        var myCollection = new List<int>() { 1, 2, 3, 4, 5 };
        return myCollection[99];
    }
    
    public static void HelloStackOverflowException()
    {
        Console.WriteLine("Hello");
        HelloStackOverflowException();
    }
    
    public static void HelloInvalidOperationException()
    {
        var myCollection = new List<int>() { 1, 2, 3, 4, 5 };
        foreach(var item in myCollection)
        {
            if (item % 2 == 0)
                myCollection.Remove(item);
        }
    }
    
    
    public class ProcessedData
    {
        public ProcessedData() {}
    }
	
    public class SensorData
    {
        public SensorData() {}
    }
}