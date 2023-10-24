using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackTest : MonoBehaviour
{
    private void Start()
    {
        Stack stack = new Stack();

        stack.Push("1");
        stack.Push("2");
        stack.Push("3");

        while (stack.Count > 0)
        {
            Debug.Log(stack.Pop());
        }
    }
}