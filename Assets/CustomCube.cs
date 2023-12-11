using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCube : MonoBehaviour
{
    public string Test;
    public int Test123;
    public TestTest TestClassInstance;

    [System.Serializable]
    public class TestTest
    {
        public string Test;
        public int TestNumber;
    }
    
    private void Awake()
    {
        
        Debug.Log(TestClassInstance.TestNumber);
        Debug.Log(TestClassInstance.Test);
    }

    private void Start()
    {
        
    }

    private void Update()
    {
    }

    private void OnDestroy()
    {
        
    }

    public void TestFunction()
    {
        Debug.Log(Test);
    }
}
