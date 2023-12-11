using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryTest : MonoBehaviour
{
    Dictionary<string, int> Fruits = new Dictionary<string, int>()
    {
        {"Banana", 5 },
        {"Mango", 10 }
    };

    private void Start()
    {
        bool b1 = Fruits.ContainsKey("Mango");
        bool b2 = Fruits.ContainsValue(10);
        bool b3 = Fruits.TryGetValue("Banana", out int value);

        Debug.Log($"{b1}, {b2}, {b3}");
    }
}
