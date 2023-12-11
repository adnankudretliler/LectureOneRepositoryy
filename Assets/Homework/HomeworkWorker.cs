using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class HomeworkData
{
    public int InputNumber;

    public string[] Results = Enumerable.Range(0, 100).Select(x => $"Number - {x}").ToArray();
}
public class HomeworkWorker
{
    // 
    // find the number of odd numbers from 0 to input number
    // let the number of odd numbers as index "i"
    // return i. item in Results array
    //
    
    public static string ProcessData(HomeworkData data)
    {
        return "";
    }
}
