using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class d
{
    void Start()
    {
        //StaticTest.Instance. //...동작 수행
    }
}

public class StaticTest : MonoBehaviour
{
    public static StaticTest Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }

    private void Start()
    {
        transform.SetPositionX(5f);
    }


    //private void Start()
    //{
    //    StaticClass.StaticFunc();
    //}

    //static int age = 10;
    //int birth = 2006;

    //public static void StaticFunc()
    //{
    //    age = 44;
    //}
}

public static class StaticClass
{
    static int age = 18;

    public static void StaticFunc()
    {
        Debug.Log("static class");
    }
}

public static class ExtensionMethod
{
    public static bool IsNumberic(this string s)
    {
        float output;
        return float.TryParse(s, out output);
    }
}

public static class TransformExtensions
{
    public static void SetPositionX(this Transform transform, float x)
    {
        var newPosition = new Vector3(x, transform.position.y, transform.position.z);
        transform.position = newPosition;
    }
}
