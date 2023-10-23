using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyExample : MonoBehaviour
{
    public PropertyTest test;

    private void Start()
    {
        int age = test.Age;
       
        //test.Age = 18;
    }
}
