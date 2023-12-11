using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeworkComponent : MonoBehaviour
{
    private void Awake()
    {
        HomeworkData data = new HomeworkData()
        {
            InputNumber = 197
        };
        
        Debug.Log(HomeworkWorker.ProcessData(data));
    }
}
