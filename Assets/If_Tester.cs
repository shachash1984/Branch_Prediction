using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class If_Tester : MonoBehaviour
{
    public TextMeshProUGUI ResultText;
// Start is called before the first frame update
    void Start()
    {
        //arrayListTest();
        TestBranchPred();
    }
    void arrayListTest()
    {
        ResultText.text = "Array List Test\n";
        int numIterations = 100000;
        int size = 1024;
        int[] intArray = new int[size];
        List<int> intList = new List<int>(size);
        for (int i = 0; i < size; i++)
        {
            intArray[i] = i;
            intList.Add(i);
        }
        float testTime1 = 0.0f;
        float testTime2 = 0.0f;
        for (int i = 0; i < numIterations; i++)
        {
            float time1 = Time.realtimeSinceStartup;
            for (int j = 0; j < intArray.Length; j++)
                if (j < intArray.Length)
                {
                    intArray[j]++;
                }
                
            testTime1 += Time.realtimeSinceStartup - time1;
            float time2 = Time.realtimeSinceStartup;
            for (int j = 0; j < intList.Count; j++)
                intList[j]++;
            testTime2 += Time.realtimeSinceStartup - time2;
        }
        Debug.Log(testTime1 + " Array");
        ResultText.text += testTime1 + " Array\n";
        Debug.Log(testTime2 + " List");
        ResultText.text += testTime2 + " List\n";
    
    }


    void TestBranchPred()
    {
        ResultText.text = "Branch prediction Test\n";
        int numIterations = 10000000;
        int testInt1 = 0;
        int testInt2 = 0;
        float testTime1 = 0.0f;
        float testTime2 = 0.0f;
        for (int i = 0; i < numIterations; i++)
        {
            float time1 = Time.realtimeSinceStartup;
            testInt1++;
                
            testTime1 += Time.realtimeSinceStartup - time1;
            float time2 = Time.realtimeSinceStartup;
            if (testInt1 > 0)
            {
                testInt2++;
            }
            
            
            testTime2 += Time.realtimeSinceStartup - time2;
        }
        Debug.Log(testTime1 + " no branch");
        ResultText.text += testTime1 + " no branch\n";
        Debug.Log(testTime2 + " with branch");
        ResultText.text += testTime2 + " with branch\n";
    }

     
}
