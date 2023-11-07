using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateTest : MonoBehaviour
{
    delegate void dt(int a);

    public void func(int a)
    {
        Debug.Log(a);
    }

    private void Start()
    {
        dt dt1;
        dt1 = func;
        dt1 += func;
        dt1(5);

        dt dt2 = new dt(func);

        dt dt3 = (a) =>
        {
            Debug.Log($"func : {a}");
        };

        dt dt4 = delegate (int a)
        {
            Debug.Log($"func : {a}");
        };

        dt4(10);
    }
}