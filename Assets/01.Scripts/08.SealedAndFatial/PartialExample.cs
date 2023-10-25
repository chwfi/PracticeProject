using System.Collections;
using System.Collections.Generic;
using UnityEngine;

partial class PartialExample : MonoBehaviour
{
    int a = 10;

    private void Start()
    {
        Debug.Log($"{a}, {b}");
    }
}

partial class PartialExample : MonoBehaviour
{
    int b = 5;
}