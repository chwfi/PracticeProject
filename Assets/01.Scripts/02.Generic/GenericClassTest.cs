using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericClass<T>
{
    public T value; //���׸� Ŭ���� ���� T�� ���� ����
}

public class GenericClassTest : MonoBehaviour
{
    private void Start()
    {
        GenericClass<int> class01 = new GenericClass<int>(); //int������ Ŭ������ü ����
        class01.value = 1; //int������ ��ü�� ���������Ƿ� ���� value ������ int������ �ٲ��.
        Debug.Log(class01.value);

        GenericClass<string> class02 = new GenericClass<string>(); //string������ Ŭ������ü ����
        class02.value = "hello"; 
        Debug.Log(class02.value);
    }
}
