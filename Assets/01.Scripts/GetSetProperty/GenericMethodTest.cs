using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GenericMethodTest : MonoBehaviour
{
    private void Start()
    {
        SetData<int>(15);
        SetData(15); // 꺾쇠 안에 있는 형식매개변수를 생략할 수도 있다.
        SetData<float>(10.5f);
        SetData<string>("hi");
    }

    private void SetData<T>(T data)
    {
        Debug.Log(data);
    }
}
