using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallerTest : MonoBehaviour
{
    private void Start()
    {
        int a;
        Func(out a);
    }

    private void Func(out int num)
    {
        num = 5;
    }
}  
