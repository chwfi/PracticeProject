using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayListTest : MonoBehaviour
{

    private void Start()
    {
        List<int> list = new List<int>();

        System.Collections.ArrayList arrayList = new System.Collections.ArrayList();
        arrayList.Add("Hello");
        arrayList.Add(10f);
        
        for (int i = 0; i < 10; i++)
        {
            arrayList.Add(i);
        }
        foreach (var a in arrayList)
        {
            Debug.Log(a);
        }
    }  
}
