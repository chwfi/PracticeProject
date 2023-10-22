using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueTypeTest : MonoBehaviour
{
    private void Start()
    {
        int[] array = { 1, 2 };
        int[] array2 = array;
        array2[0] = 3;
        Debug.Log($"{array[0]}, {array[1]}");
        Debug.Log($"{array2[0]}, {array2[1]}");
    }
}
