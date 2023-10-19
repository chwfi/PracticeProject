using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GenericMethodTest : MonoBehaviour
{
    private void Start()
    {
        SetData<int>(15);
        SetData(15); // ���� �ȿ� �ִ� ���ĸŰ������� ������ ���� �ִ�.
        SetData<float>(10.5f);
        SetData<string>("hi");
    }

    private void SetData<T>(T data)
    {
        Debug.Log(data);
    }
}
