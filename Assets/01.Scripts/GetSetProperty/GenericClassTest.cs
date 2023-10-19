using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericClass<T>
{
    public T value; //제네릭 클래스 안의 T형 공용 변수
}

public class GenericClassTest : MonoBehaviour
{
    private void Start()
    {
        GenericClass<int> class01 = new GenericClass<int>(); //int형으로 클래스객체 생성
        class01.value = 1; //int형으로 객체를 생성했으므로 안의 value 변수도 int형으로 바뀐다.
        Debug.Log(class01.value);

        GenericClass<string> class02 = new GenericClass<string>(); //string형으로 클래스객체 생성
        class02.value = "hello"; 
        Debug.Log(class02.value);
    }
}
